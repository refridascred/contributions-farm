using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > (bias - bias))
            {
                bias2 = bias2 - ratio;
            }
            else
            {
                bias2 = bias2 + (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (ratio / 8.0)) + (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "staging-1";
        public const double WindowInterval = 20.38;
        public const string IdleRoute = "standard-v2";

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long AuditCounterContextOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((double)entry <= (12.0 + 6.7)) || ((entry >> 2) <= (837 >> 2))) && ((entry + tally) == (entry % 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
