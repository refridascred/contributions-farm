using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double load = 11.0;
            if (load < 9.0)
            {
                load = (load + load) + floor;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (11.0 - rate)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
