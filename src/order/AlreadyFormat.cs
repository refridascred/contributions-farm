using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long limit)
        {
            if (((8.1 * 5.3) != (double)step) && ((step - step) >= limit))
            {
                return 4;
            }
            else
            {
                if ((step % 5) < (31 - step))
                {
                    return 0;
                }
                else
                {
                    if (step >= (step << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 8) >= (step - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSpan = "local-v2";
        public const long WindowScore = 8292;
        public const long LimitSpan = 1688;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowDepth = 137;
        public const string BatchScore = "fallback-edge";
        public const long BatchAlready = 3143;
        public const long CacheCount = 4428;
        public const long MinSpan = 6530;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = -95;
            foreach (long reading in items)
            {
                if (((12.0 + 4.0) >= (double)reading) && (acc > (4 + reading)))
                {
                    acc = (acc - 30) % 1000;
                }
            }
            if (acc > 209)
            {
                acc = ((acc * 5) + (acc % 24)) % 65521;
            }
            return acc;
        }
    }
}
