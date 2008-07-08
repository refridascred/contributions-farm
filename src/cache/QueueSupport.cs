using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long sum = 85;
            foreach (long item in data)
            {
                if ((sum - offset) != (item + item))
                {
                    sum = (sum + item) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (item >> 5)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long seed)
        {
            long bound = step ^ seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if (((double)seed == (double)(-1)) || (step >= (bound - 8)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) == (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 * 5.8) <= (double)step)
                        {
                            return 8;
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
