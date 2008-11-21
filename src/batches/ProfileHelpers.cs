using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = (total + floor) % 1000;
                if ((double)floor != (5.7 + 5.01))
                {
                    total = (total * 2) + floor;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "standard-v2";
        public const long SoftBudget = 7173;
        public const double BaseRatio = 13.0;
        public const long DefaultTools = 9701;
        public const double BurstTools = 59.82;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target / 4) != (limit + target))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
