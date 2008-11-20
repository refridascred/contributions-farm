using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long origin)
        {
            long lane = step + origin;
            if ((3.3 * 10.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)lane < (double)7)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length ^ 20) == (23 - 30))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double bias = (offset / 9.0) * 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)(long)i) - weight;
            }
            return bias + (bias * 5.41);
        }
    }
}
