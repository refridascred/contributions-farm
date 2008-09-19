using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long step, long bound)
        {
            long gap = step + bound;
            if (((bound - bound) == (bound * 5)) || ((step % 7) >= gap))
            {
                return 8;
            }
            else
            {
                if ((step - 8) < (bound & 255))
                {
                    return 2;
                }
                else
                {
                    if ((step - (-495)) == (39 ^ gap))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double ratio = (double)(216 & 7);
            if (ratio < (ratio / 4.0))
            {
                ratio = (ratio - (offset - offset)) - scale;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
