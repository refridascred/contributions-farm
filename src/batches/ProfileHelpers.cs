using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheWidth = 7962;
        public const double MaxScore = 79.34;
        public const long MaxDepth = 5213;
        public const double RetryContributi = 48.42;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long limit2)
        {
            if (!((limit % 3) == (limit + 76)))
            {
                return 0;
            }
            else
            {
                if (((double)limit2 < (double)(-6)) || ((limit2 / 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) >= (limit2 - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit < (limit2 % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                if (mix > (long)i)
                {
                    mix = (mix << 3) ^ (limit * 3);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
