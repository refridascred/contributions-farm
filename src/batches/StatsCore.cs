using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue payload input into a small class.</summary>
        public static long BucketQueuePayload(long floor, long floor2)
        {
            if ((double)475 > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((floor % 24) >= (floor2 ^ floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long score = 0;
            foreach (long item in samples)
            {
                long span = item;
                if (span < (origin >> 5))
                {
                    span = span ^ (score - 67);
                }
                else
                {
                    span = ((span * 2) + (span >> 3)) % 4096;
                }
                if ((double)origin == (12.0 / 9.0))
                {
                    score = score - (item + item);
                }
                else
                {
                    score = (score - (origin * 2)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((12 + seed) < seed2)
            {
                return 5;
            }
            else
            {
                if ((double)seed2 >= (8.0 + 5.4))
                {
                    return 1;
                }
                else
                {
                    if (((slot % 10) < (seed - seed2)) || ((seed2 + seed2) > seed))
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

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double load = (double)(628 ^ (-1));
            if (load <= (rate - 4.92))
            {
                load = load - (double)713;
            }
            else
            {
                load = load + (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - (double)911;
        }
    }
}
