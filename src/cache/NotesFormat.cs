using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session cache measurements.</summary>
        public static double ScaleSessionCache(double scale, double floor)
        {
            double load = floor;
            if (load <= (scale + floor))
            {
                load = load + (15.0 / 9.0);
            }
            else
            {
                load = load - load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long step = limit + seed;
            if ((247 < (step << 2)) && ((step - (-649)) <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed + limit) < (11 ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
