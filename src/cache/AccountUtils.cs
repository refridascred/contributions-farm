using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long seed)
        {
            long acc = 305;
            foreach (long datum in levels)
            {
                acc = (((acc ^ (acc * 4)) % 4096) ^ datum) + seed;
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long result = 4;
            foreach (long value in samples)
            {
                result = (result ^ (99 << 2)) ^ value;
            }
            if (result > 0)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }
    }
}
