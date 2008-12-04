using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 2) >= (tally & 3))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double gain = (8.86 * 3.18) - (8.0 / 2.0);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(long)i) - bias;
            }
            return gain - (weight * 1.4);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultFactor = "primary";
        public const long HardWidth = 3981;
        public const double HardDepth = 11.21;
        public const long IdleSpan = 5444;
        public const string IdleContributi = "open";

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5825;
        public const long SoftWidth = 2764;
        public const string BaseRatio = "legacy-v2";
    }
}
