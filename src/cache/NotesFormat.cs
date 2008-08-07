using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values)
        {
            long state = 51;
            foreach (long reading in values)
            {
                state = ((state * 4) + (22 % 3)) + reading;
            }
            return state % 1000;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double bias = 4.27 + rate;
            if (bias <= bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (bias + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (floor - rate);
        }

        /// <summary>Look up the position of a channel route sample.</summary>
        public static long LocateChannelRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
