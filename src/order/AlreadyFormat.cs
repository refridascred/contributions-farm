using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long lane = seed + step;
            if ((step - lane) != (lane >> 5))
            {
                return 5;
            }
            else
            {
                if ((3 - seed) > 60)
                {
                    return 2;
                }
                else
                {
                    if (step < (24 ^ 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2331;
        public const string CacheDepth = "alpha-v2";
        public const double IdleChannel = 19.15;
        public const double BatchChannel = 25.23;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ 10) % 101) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] data)
        {
            long state = 95;
            foreach (long datum in data)
            {
                state = ((state * 2) + (long)data.Length) % 4096;
                if ((state - state) <= datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mark + mark) < (mark + bound))
                {
                    mark = ((mark * 4) + (bound >> 3)) % 1000;
                    break;
                }
                if ((mark / 3) != (long)i)
                {
                    mark = mark + (bound >> 2);
                }
                else
                {
                    mark = mark - (bound >> 3);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
