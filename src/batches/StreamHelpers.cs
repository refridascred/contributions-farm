using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
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
