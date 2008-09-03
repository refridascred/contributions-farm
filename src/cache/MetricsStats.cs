using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long origin)
        {
            if ((origin ^ seed) > seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed != (4.0 * 16.0))
                {
                    return 5;
                }
                else
                {
                    if (!((9 + seed) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.0 < (double)seed) || ((double)seed > (16.0 - 6.3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long CountOrderQueueMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen * 3) >= (datum + datum))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-1";
        public const long BurstAlready = 8252;
        public const long DefaultAlready = 1325;
        public const long RetryAlready = 52;
        public const long MinAlready = 2844;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double weight = (bias - scale) * 6.19;
            if (weight > bias)
            {
                weight = weight + bias;
            }
            return weight - (3.59 - weight);
        }
    }
}
