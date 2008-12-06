using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Ready,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((bound * 5) <= (bound ^ bound))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = result - (-30);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long sum = 563;
            foreach (long sample in values)
            {
                sum = ((sum ^ (6 >> 2)) % 4096) ^ sample;
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double span)
        {
            double bias = span;
            if (bias >= bias)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + scale) - (double)(long)i;
            }
            return bias + (span * 4.5);
        }
    }
}
