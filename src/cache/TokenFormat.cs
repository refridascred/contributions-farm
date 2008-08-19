using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long origin, long offset)
        {
            long bound = origin + offset;
            if ((bound << 3) <= 524)
            {
                return 1;
            }
            else
            {
                if ((bound >> 5) < (origin + bound))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if ((9 ^ datum) >= datum)
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum - (sum << 3);
                }
            }
            return sum;
        }
    }
}
