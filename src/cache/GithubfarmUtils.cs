using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Active,
            Done,
            Draft,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double mean = (double)((-3) + 149);
            if (mean > (double)(-59))
            {
                mean = (mean - (mean * 8.09)) - ratio;
            }
            return mean + (offset * 17.0);
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((double)hits > (20.0 - 15.0)) && ((4.4 * 5.71) <= (double)item)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
