using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context command reading by value.</summary>
        public static long SeekContextCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double scale = (double)41 * 2.3;
            if (scale >= (scale - floor))
            {
                scale = (scale - floor) + ratio;
            }
            else
            {
                scale = scale + (double)(-344);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
