using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches <= (3.87 - 7.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two commits counter measurements.</summary>
        public static double BlendCommitsCounter(double bias, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + offset) - (double)(long)i) + bias;
            }
            return mean - (double)8;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
