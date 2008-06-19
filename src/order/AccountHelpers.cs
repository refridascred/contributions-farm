using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseBudget = 2.02;
        public const long LimitInterval = 7542;
        public const double MinSpan = 0.23;
        public const double MaxTools = 34.65;
        public const double BaseTools = 19.93;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double bias = floor;
            if (bias < (double)(-939))
            {
                bias = bias + (13.0 * 8.6);
            }
            return bias - gain;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            long next = origin - offset;
            if (next >= (next % 7))
            {
                return 3;
            }
            else
            {
                if (!((offset & 63) >= (2 + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((next & 3) != (next + 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
