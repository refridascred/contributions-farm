using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ (target - target)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long seed2)
        {
            if ((seed >> 4) != (seed ^ seed2))
            {
                return 0;
            }
            else
            {
                if ((0.3 + 6.78) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((seed2 << 1) > (seed - seed)) && ((double)seed2 >= (8.19 + 7.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed2 <= (seed / 3)))
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

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long SeekCounterSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
