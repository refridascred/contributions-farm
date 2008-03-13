using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long seed)
        {
            long sum = 451;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 2) + (sum * 5)) % 1000) ^ (long)i;
                }
                sum = sum + (long)items.Length;
                if (((18.0 - 7.5) != (double)datum) && ((seed * 3) != (datum * 4)))
                {
                    sum = sum ^ 949;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Grade a cache profile value against two limits.</summary>
        public static long ClassifyCacheProfile(long bound, long origin)
        {
            if (!(origin > (origin / 8)))
            {
                return 4;
            }
            else
            {
                if ((bound - 53) <= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
