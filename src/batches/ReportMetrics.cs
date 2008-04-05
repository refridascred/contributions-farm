using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitDepth = 90.75;
        public const long SoftCluster = 9661;
        public const long MinDepth = 3064;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double weight = rate;
            if (weight < weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
