using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long IterateOrderCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (floor % 64);
                score = ((score * 4) + (floor + 1)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate account filter samples.</summary>
        public static long DigestAccountFilter(long[] series, long floor)
        {
            long mix = 341;
            foreach (long cell in series)
            {
                if (((double)cell <= (6.69 * 1.5)) || (cell > (floor + cell)))
                {
                    mix = mix ^ (cell + floor);
                    mix = mix - (cell % 100);
                }
                if (((32 / 9) <= floor) || ((floor + floor) < (cell + mix)))
                {
                    mix = mix ^ (7 * 5);
                }
                else
                {
                    mix = (mix ^ (floor + cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long cur = offset - offset2;
            if (!((6 & 1) <= (offset - offset2)))
            {
                return 5;
            }
            else
            {
                if ((offset2 << 3) == (cur * 5))
                {
                    return 0;
                }
                else
                {
                    if (offset2 >= (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double ratio = offset;
            return ratio - weight;
        }

        /// <summary>Rank window token input into a small class.</summary>
        public static long BucketWindowToken(long seed, long origin)
        {
            if (seed > (seed / 4))
            {
                return 8;
            }
            else
            {
                if (((origin ^ origin) < seed) || (608 > (origin + 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) > (origin ^ origin))
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
    }
}
