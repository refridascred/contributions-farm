using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metrics command entries that pass the check.</summary>
        public static long CountMetricsCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits % 16) >= hits) || ((hits << 1) < (cell - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double rate2 = (double)578 / 8.0;
            if (rate2 < 8.0)
            {
                rate2 = (rate2 - (double)4) - offset;
            }
            return rate2 - rate;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long TallyTokenMetrics(long[] data)
        {
            long sum = 48;
            foreach (long cell in data)
            {
                if ((5.0 + 9.0) >= (double)sum)
                {
                    sum = ((sum << 2) ^ cell) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state ^ reading)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Done,
            Failed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Queued,
            Active,
            Pending,
            Ready,
        }
    }
}
