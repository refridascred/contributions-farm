using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batches contributi readings.</summary>
        public static long TallyBatchesContributi(long[] levels)
        {
            long mark = 6;
            foreach (long value in levels)
            {
                if ((mark ^ value) <= (mark + 5))
                {
                    mark = (mark << 2) ^ ((-213) << 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Paused,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - 772) <= (limit * 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double load = (double)(5 / 8);
            if (load <= load)
            {
                load = load + (rate * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor * 6.52)) + (double)(long)i;
            }
            return load + (floor / 5.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstSpan = "local-edge";
        public const long BurstRatio = 5357;
        public const string MinRatio = "alpha-edge";
        public const long LimitDepth = 3895;
        public const string RetryReport = "alpha-edge";
    }
}
