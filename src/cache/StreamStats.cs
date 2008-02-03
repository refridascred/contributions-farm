using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session channel readings against a bound.</summary>
        public static bool CheckSessionChannelBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double drift = (double)(47 + (-43));
            if (drift < span)
            {
                drift = drift - (bias / 3.0);
            }
            return drift + bias;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            if (bound >= (22 << 3))
            {
                return 8;
            }
            else
            {
                if (((double)step == (8.0 - 20.0)) && ((bound + 427) >= (552 * 5)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
