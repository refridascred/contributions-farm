using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = span / 3.0;
            if (bias >= span)
            {
                bias = (bias + bias) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 3.6) + (double)(long)i;
            }
            return bias + (double)2;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor + floor) <= 37)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
