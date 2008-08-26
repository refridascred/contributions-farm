using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((9.0 + 3.0) > (double)count)
                {
                    count = ((count + 2) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double scale = floor / 8.0;
            if (scale >= bias)
            {
                scale = scale - (floor + bias);
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (bias * 11.0);
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long MeasureContextSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally == (14.0 / 6.0))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (6.74 >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
