using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long step2)
        {
            if ((0.13 / 4.0) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((775 + 9) < step)
                {
                    return 7;
                }
                else
                {
                    if ((180 + step) >= (7 + 846))
                    {
                        return 4;
                    }
                    else
                    {
                        if (758 > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (7.8 + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (((sample & 31) >= (sample + sample)) && ((state % 24) != (state + state)))
                {
                    state = (state + (sample * 3)) % 4096;
                }
            }
            return state;
        }
    }
}
