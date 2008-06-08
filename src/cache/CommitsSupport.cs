using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
