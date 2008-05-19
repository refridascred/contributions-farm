using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples, long origin)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if (((98 + entry) <= entry) && ((6 << 1) > (entry << 1)))
                {
                    total = ((total * 4) + (658 - total)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (-950)) % 4096;
                }
                total = ((total * 2) + entry) % 101;
            }
            if (total < 13)
            {
                total = (total + (origin << 2)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long DeriveCommandEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 3) ^ offset) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
