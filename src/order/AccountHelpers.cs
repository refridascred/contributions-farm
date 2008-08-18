using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.6 + 3.0) >= (double)hits)
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }
    }
}
