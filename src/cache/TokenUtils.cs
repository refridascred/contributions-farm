using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (5.01 > (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Validate route stream readings against a bound.</summary>
        public static bool ValidateRouteStreamRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
