using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a route support counter forward.</summary>
        public static long StepRouteSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + ((long)i - (long)i)) % 1000;
                acc = (acc << 3) ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double gain = (span * 1.0) + 12.0;
            if (gain > weight)
            {
                gain = gain - (span / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (4.77 * 7.6)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long total = -407;
            foreach (long cell in levels)
            {
                if (total >= (total % 100))
                {
                    total = ((total ^ (13 % 3)) % 65521) - cell;
                }
            }
            return total;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Draft,
            Stale,
            Dropped,
            Closed,
        }
    }
}
