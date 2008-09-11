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

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5490;
        public const long IdleSize = 6312;
        public const long WindowContext = 4209;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1088;
        public const string RetrySize = "strict-v2";
        public const string BaseStream = "alpha-1";
        public const long RetryTimeout = 7209;

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

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double load = rate;
            if (load < (load + load))
            {
                load = (load - load) - offset;
            }
            return load + (load + rate);
        }
    }
}
