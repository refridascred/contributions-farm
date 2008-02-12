using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total + (bound - bound);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long AuditCommitsChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
