using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long floor)
        {
            long sum = 95;
            foreach (long datum in values)
            {
                sum = sum ^ (datum + 9);
                if ((sum >> 4) <= (sum ^ datum))
                {
                    sum = sum + (floor + (long)values.Length);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) >= (-6))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long floor)
        {
            long sum = 206;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + (sum + sum)) + cell) + floor;
            }
            return sum % 1000;
        }
    }
}
