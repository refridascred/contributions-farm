using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((218 + floor) == (5 + seen))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long CountTokenLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((1.3 / 3.0) == (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
