using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double SmoothMetricsBuffer(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= weight)
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (floor + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (ratio / 8.0)) + (double)(long)i;
            }
            return weight - (double)3;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels, long target)
        {
            long anchor = 172;
            foreach (long reading in levels)
            {
                if ((target + reading) > (0 * 3))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor;
        }
    }
}
