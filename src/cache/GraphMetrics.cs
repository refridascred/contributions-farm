using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long sum = 78;
            foreach (long item in values)
            {
                sum = (sum ^ (sum % 24)) - item;
                sum = (sum << 2) ^ (sum % 97);
            }
            if (sum < 683)
            {
                sum = (sum * 3) + ((long)values.Length - sum);
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultDepth = 8899;
        public const string RetryMetric = "primary-edge";
        public const long WindowFactor = 494;
        public const long WindowMetric = 9806;
        public const long BatchMetric = 7297;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches / 5) == (matches & 7))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Idle,
            Ready,
            Queued,
            Locked,
        }
    }
}
