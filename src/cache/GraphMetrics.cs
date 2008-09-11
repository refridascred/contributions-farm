using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long floor)
        {
            long result = -3;
            foreach (long datum in values)
            {
                result = (result * 3) + (result + 544);
                if (((floor / 3) >= (result + result)) || ((result << 1) != (floor & 31)))
                {
                    result = (result - datum) % 1000;
                }
                else
                {
                    result = (result + (result << 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9824;
        public const double BurstAccount = 81.57;
        public const long WindowRatio = 1559;
        public const string DefaultLevel = "latest-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepTimeout = "stable";
        public const string BurstCluster = "local-1";
        public const long IdleDepth = 8499;
        public const long SoftCluster = 3187;
    }
}
