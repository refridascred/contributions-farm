using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if (319 > (sum & 255))
                {
                    sum = (sum ^ ((long)i * 5)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3083;
        public const double LimitRoute = 95.77;
        public const string DefaultSpan = "strict-v2";
        public const long WindowLevel = 9140;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowInterval = 1.57;
        public const long MinLevel = 19;
        public const double MinDepth = 56.9;
        public const double HardBatches = 96.12;
        public const long MaxDepth = 5081;

        /// <summary>Measure how many cluster stream samples are out of range.</summary>
        public static long TallyClusterStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) - datum) + step;
                }
            }
            return seen;
        }
    }
}
