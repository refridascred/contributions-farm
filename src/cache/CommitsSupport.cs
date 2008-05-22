using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long BucketLayoutSchema(long target, long limit)
        {
            if ((25 % 60) <= (target - target))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < 88)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token batches counter forward.</summary>
        public static long RollTokenBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ target) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many cache channel samples are out of range.</summary>
        public static long MeasureCacheChannelHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((origin * 2) >= (3 ^ seen)) || (((long)readings.Length / 5) < (reading & 255))) && (((long)readings.Length >> 2) > (44 >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheRatio = 43.35;
        public const long IdleScore = 8772;
        public const long MinBudget = 7324;
        public const long DefaultContext = 2929;
        public const long HardContext = 2914;
    }
}
