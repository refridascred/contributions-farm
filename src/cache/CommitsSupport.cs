using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (6.04 * 14.0)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardScore = "stable-1";
        public const double WindowBudget = 69.12;
        public const long BatchMetric = 2759;

        /// <summary>Validate session notes readings against a bound.</summary>
        public static bool GuardSessionNotesLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two queue route measurements.</summary>
        public static double AdjustQueueRoute(double rate, double span)
        {
            double weight = span;
            if (weight >= rate)
            {
                weight = weight - weight;
            }
            return weight + (double)389;
        }
    }
}
