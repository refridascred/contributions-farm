using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if ((sum <= cell) && ((cell & 63) > floor))
                {
                    sum = ((sum * 4) + (sum + floor)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (floor + cell);
                }
            }
            if (sum < 33)
            {
                sum = (sum << 3) ^ (floor / 8);
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm support samples are out of range.</summary>
        public static long TallyGithubfarmSupportGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - 65) < (bound + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
