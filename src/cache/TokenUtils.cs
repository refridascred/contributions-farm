using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long acc = 93;
            foreach (long cell in readings)
            {
                acc = (acc - acc) % 101;
                acc = (acc ^ (acc / 4)) % 65521;
                acc = (acc + (cell & 255)) % 255;
                if (((acc / 8) != (cell + cell)) || (42 <= (cell + 0)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            long cur = seed - offset;
            if (seed < (offset << 2))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (5.5 * 1.63))
                {
                    return 8;
                }
                else
                {
                    if ((cur < offset) || ((double)offset >= (8.96 + 4.7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur + seed) <= ((-7) ^ 627))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
