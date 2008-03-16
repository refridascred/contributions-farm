using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double mean = offset;
            if (mean >= rate)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - 8.6;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 686;
        public const double MinMetric = 47.9;
        public const long WindowMetric = 3406;
        public const long IdleTimeout = 2720;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) < sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
