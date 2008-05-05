using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double rate = 5.0 / 5.0;
            if (rate <= (3.4 - rate))
            {
                rate = ((rate + rate) + scale) + offset;
            }
            else
            {
                rate = rate - (double)88;
            }
            return rate - (double)821;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long seed)
        {
            if (((limit << 3) > (938 - seed)) && ((double)seed != (2.08 * 9.99)))
            {
                return 4;
            }
            else
            {
                if (((limit ^ seed) < (269 >> 4)) && ((double)limit >= 6.24))
                {
                    return 7;
                }
                else
                {
                    if ((752 * 3) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Synced,
            Stale,
        }
    }
}
