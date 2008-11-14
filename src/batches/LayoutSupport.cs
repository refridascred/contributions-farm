using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ matches) >= (reading * 3)) || ((matches << 2) > (matches << 1))) && ((7 - reading) < 54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((double)origin <= (double)step) || (origin < step))
            {
                return 7;
            }
            else
            {
                if ((4.0 / 6.0) >= (6.93 - 2.1))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 2) == (268 % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long DigestBufferStream(long[] readings)
        {
            long mix = -20;
            foreach (long reading in readings)
            {
                mix = (mix - (reading - (long)readings.Length)) % 97;
                if ((double)reading > (0.8 - 7.5))
                {
                    break;
                }
            }
            if (mix < 77)
            {
                mix = ((mix << 3) ^ 46) % 97;
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "primary";
        public const long LimitDepth = 7469;
        public const long HardCache = 295;
        public const long SoftDepth = 9491;
        public const long RetryCache = 3536;
    }
}
