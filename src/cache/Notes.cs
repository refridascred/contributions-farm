using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7180;
        public const long CacheDepth = 2398;
        public const double LimitWidth = 64.63;
        public const double BurstMetrics = 59.36;

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long CountLayoutStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((17.0 - 7.5) < (double)seen) || ((datum + (-536)) < (datum - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double mean = rate + (double)16;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (double)254) + (double)(long)i) - floor;
            }
            return mean - rate;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Closed,
            Done,
            Draft,
            Locked,
        }
    }
}
