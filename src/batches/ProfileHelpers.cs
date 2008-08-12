using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((hits + (long)readings.Length) <= reading) || (((-2) % 2) >= reading)) && (((hits - 760) < (reading + hits)) && ((reading >> 3) <= (66 << 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long CountBufferClusterOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((6.8 + 0.1) <= (double)limit)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Ready,
            Active,
            Dropped,
            Done,
        }
    }
}
