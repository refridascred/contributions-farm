using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double rate = (double)((-12) << 1);
            if (rate >= (double)5)
            {
                rate = rate + (ratio - 9.65);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (floor * 19.0);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long origin)
        {
            if ((step >> 1) < ((-78) * 4))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (2.0 - 3.89))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric record samples.</summary>
        public static long CombineMetricRecord(long[] data, long seed)
        {
            long state = -4;
            foreach (long cell in data)
            {
                if (seed >= (seed - 471))
                {
                    state = (state ^ (cell & 31)) % 1000;
                }
            }
            return state;
        }
    }
}
