using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long seed)
        {
            if (656 >= step)
            {
                return 4;
            }
            else
            {
                if (((step ^ seed) == (step * 4)) && ((double)seed <= (2.65 - 2.67)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (seed & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) > (3 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) == ((long)series.Length >> 3))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if ((datum % 97) < (2 / 6))
                {
                    sum = ((sum ^ (sum - sum)) % 65521) + seed;
                }
                else
                {
                    sum = (sum - (sum << 3)) % 255;
                }
            }
            return sum;
        }
    }
}
