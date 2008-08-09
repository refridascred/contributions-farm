using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double floor)
        {
            double weight = (bias - floor) * 4.3;
            return weight - floor;
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long CountProfileNotesGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((24 < (377 + matches)) || (458 <= (matches + 7)))
                {
                    matches = ((matches + 1) ^ sample) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + 643) < (count - sample)) || ((2.77 - 16.0) < (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long TallyEditorMetricsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum < (datum + datum))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
