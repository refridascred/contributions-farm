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

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "stable-v2";
        public const long DefaultTimeout = 792;
        public const long DefaultSpan = 5908;
        public const double LimitBudget = 91.88;

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

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
