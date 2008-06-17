using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next format entry value.</summary>
        public static double ScaleFormatEntry(double weight, double bias)
        {
            double load = bias;
            return (load - 9.0) + weight;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)limit > (8.0 - 1.59))
            {
                return 8;
            }
            else
            {
                if ((diff >> 4) == (seed + diff))
                {
                    return 2;
                }
                else
                {
                    if (diff <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff >= (11.0 + 9.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((target ^ anchor) < (anchor * 2)))
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                if ((anchor <= (348 - anchor)) && (((long)i + anchor) != (long)i))
                {
                    anchor = (anchor + (7 + target)) % 1000;
                }
                else
                {
                    anchor = (anchor + (long)i) % 101;
                    anchor = (anchor * 5) + (anchor & 1);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
