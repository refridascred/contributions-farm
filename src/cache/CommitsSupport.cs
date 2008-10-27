using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long AuditClusterBufferMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)origin <= 2.38)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9707;
        public const long IdleWidth = 2646;
        public const double WindowSize = 95.7;
        public const long LimitCache = 4374;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight - (offset + scale);
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset / 4.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 6168;
        public const string BaseSize = "staging-1";
        public const string BurstRatio = "stable";
        public const long StepBudget = 5848;
        public const string BurstTimeout = "open";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
