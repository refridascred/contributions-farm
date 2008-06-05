using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long SeekSessionOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + (mix - step)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheScore = "standard-1";
        public const double WindowFarm = 41.32;
        public const long BatchScore = 3233;
        public const long HardFarm = 2519;

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowScore = 6.83;
        public const string BaseChecks = "cached-v2";
        public const long BatchChecks = 7747;
    }
}
