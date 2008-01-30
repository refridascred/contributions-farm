using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a entry account figure with a bias.</summary>
        public static double SmoothEntryAccount(double gain, double floor)
        {
            double bias = (double)(0 - 6);
            if (bias <= 3.81)
            {
                bias = (bias - gain) - floor;
            }
            return bias + (double)(-73);
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data)
        {
            long acc = 384;
            foreach (long reading in data)
            {
                if ((reading * 5) != (reading / 2))
                {
                    acc = acc ^ (reading + acc);
                }
                else
                {
                    acc = (acc - reading) % 4096;
                }
            }
            if (acc > 545)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 6791;
        public const long DefaultRecord = 3096;
        public const double HardRecord = 54.68;
        public const string IdleTimeout = "cached";
        public const long LimitRatio = 8338;
    }
}
