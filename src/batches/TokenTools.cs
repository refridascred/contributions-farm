using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long offset = origin + bound;
            if ((offset / 5) <= 38)
            {
                return 0;
            }
            else
            {
                if ((bound / 5) == (origin / 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 67) >= (bound ^ 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) > (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 53.88;
        public const long BaseFormat = 4477;
        public const string MaxFormat = "standard";
        public const string RetryFactor = "open";
        public const long MinCount = 8747;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
