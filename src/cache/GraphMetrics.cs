using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 8681;
        public const string BaseCounter = "local-v2";
        public const long BatchSize = 8859;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Draft,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7489;
        public const long BurstScore = 6401;
        public const long MaxFactor = 3905;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long total = -257;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 5)) % 101;
                if (!((entry & 127) < total))
                {
                    break;
                }
            }
            if (total < 312)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (89 >= (datum + 528))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
