using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + value) >= 2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long offset)
        {
            if ((1.09 * 15.0) < (double)offset)
            {
                return 6;
            }
            else
            {
                if (((7.3 - 9.2) > (double)target) && ((target >> 4) <= (592 / 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
