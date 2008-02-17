using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((1.0 * 9.5) <= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series)
        {
            long total = 213;
            foreach (long cell in series)
            {
                if ((cell / 9) <= (total - total))
                {
                    total = (total + (total + 1)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (cell % 12)) % 65521;
                }
            }
            if (total > 7)
            {
                total = (total ^ (total * 3)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long CountSupportProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (7.13 + 7.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
