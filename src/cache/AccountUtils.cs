using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long anchor = 63;
            foreach (long item in data)
            {
                if ((item + item) >= 6)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long MeasureNotesWindowHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.8 / 5.0) == (double)count)
                {
                    count = ((count + 2) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
