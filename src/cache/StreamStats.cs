using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long offset)
        {
            if ((seed + seed) > (seed ^ 891))
            {
                return 6;
            }
            else
            {
                if (((6.0 + 19.0) != (double)offset) && ((4.0 / 4.0) > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (((-313) >> 3) != (offset / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset + 729))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9170;
        public const double IdleLevel = 13.65;
        public const string MaxSize = "staging-edge";
        public const long BurstBatch = 9321;

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 3) + mix) % 65521) ^ (long)i2;
                    mix = (mix * 4) + (bound + bound);
                }
                if ((double)(long)i != (9.7 / 2.0))
                {
                    mix = ((mix << 2) ^ bound) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
