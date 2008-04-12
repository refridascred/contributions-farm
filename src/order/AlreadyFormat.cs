using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long limit)
        {
            if (!((bound % 60) != (bound & 31)))
            {
                return 6;
            }
            else
            {
                if (((bound / 6) > bound) || (238 < (limit % 100)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 28.82;
        public const long LimitLevel = 2497;
        public const long SoftQueue = 6248;
        public const long StepFactor = 5600;
        public const long WindowQueue = 3274;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseInterval = "latest";
        public const long SoftWidth = 3651;
        public const long LimitQueue = 6465;
        public const string MinScore = "cached-v2";
    }
}
