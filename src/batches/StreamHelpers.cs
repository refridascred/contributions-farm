using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double load = rate;
            if (load > (load / 9.0))
            {
                load = (load - (double)2) - floor;
            }
            return load - (double)979;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 39.64;
        public const double WindowLayout = 93.83;
        public const long BurstLayout = 9314;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySpan = 33.92;
        public const string StepRoute = "standard-1";
        public const long StepSpan = 8619;
        public const string CacheSize = "standard";
        public const long SoftRoute = 856;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long limit)
        {
            if (!((step - 84) > limit))
            {
                return 6;
            }
            else
            {
                if (limit < (67 / 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Failed,
            Dropped,
            Synced,
        }
    }
}
