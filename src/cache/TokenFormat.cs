using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of window tools entries.</summary>
        public static long TallyWindowTools(long[] series, long target)
        {
            long acc = 86;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ (acc & 7)) + entry) + target;
            }
            if (acc > 81)
            {
                acc = ((acc * 5) + (acc & 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count >= 69)
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
