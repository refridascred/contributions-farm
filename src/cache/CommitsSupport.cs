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

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double ratio = rate;
            if (ratio < 2.2)
            {
                ratio = (ratio - rate) - span;
            }
            else
            {
                ratio = ratio + 5.67;
            }
            return ratio + ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardScore = "stable-1";
        public const double WindowBudget = 69.12;
        public const long BatchMetric = 2759;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Queued,
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
