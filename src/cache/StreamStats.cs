using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stats token readings.</summary>
        public static long CombineStatsToken(long[] readings, long seed)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                if (1 < (seed - state))
                {
                    state = ((state + (87 / 2)) % 101) ^ entry;
                }
                else
                {
                    state = state + (875 + 292);
                }
            }
            return state;
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

        /// <summary>Look up the position of a token record sample.</summary>
        public static long FindTokenRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
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
