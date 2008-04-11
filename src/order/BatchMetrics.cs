using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (total + step)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 491;
        public const long BurstCommand = 6791;
        public const long StepCommand = 4018;
        public const double MinCommand = 72.26;
        public const string HardFactor = "latest-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 6753;
        public const long DefaultDepth = 216;
        public const string IdleTimeout = "cached";
        public const long LimitFarm = 819;
        public const long MinFarm = 8903;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                if (reading >= ((-8) & 31))
                {
                    sum = ((sum * 4) + (sum % 3)) % 101;
                }
            }
            if (sum > 906)
            {
                sum = (sum * 4) + (630 + sum);
            }
            return sum;
        }
    }
}
