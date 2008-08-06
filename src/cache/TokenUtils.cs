using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if (67 <= floor)
                {
                    score = (score + (floor << 2)) % 97;
                    continue;
                }
                if (score >= (752 % 2))
                {
                    score = ((score * 5) + ((long)i - score)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (origin < (origin + 18))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
