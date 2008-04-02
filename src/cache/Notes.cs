using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stats token values into a single score.</summary>
        public static long FoldStatsToken(long[] items, long seed)
        {
            long total = 0;
            foreach (long item in items)
            {
                total = ((total << 3) ^ (seed % 24)) % 101;
                total = (total << 3) ^ 805;
                if ((seed >> 5) >= (item + total))
                {
                    total = (total * 4) + (item / 8);
                }
            }
            return total;
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter cluster values into a single score.</summary>
        public static long FoldFilterCluster(long[] items)
        {
            long sum = 259;
            foreach (long entry in items)
            {
                if ((entry + sum) < (entry & 1))
                {
                    sum = ((sum << 2) ^ (entry << 1)) % 65521;
                }
                else
                {
                    sum = (sum - (30 + 416)) % 255;
                }
            }
            if (sum < 94)
            {
                sum = (sum << 2) ^ (sum % 8);
            }
            return sum % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
