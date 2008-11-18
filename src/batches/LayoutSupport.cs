using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) <= ((-943) + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 7644;
        public const long WindowTimeout = 4593;
        public const string IdleScore = "latest";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            if ((9 + seed) > (bound / 8))
            {
                return 3;
            }
            else
            {
                if (bound < (seed ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!(405 > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((18.0 / 2.0) <= (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count <= (7.4 * 3.0)) && ((value * 2) < (count / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
