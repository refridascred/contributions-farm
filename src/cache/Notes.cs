using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count tools support pairs that satisfy a relation.</summary>
        public static long OverlapToolsSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9522;
        public const long BurstAlready = 4551;
        public const long IdleAlready = 6603;
        public const double MaxAlready = 3.35;
        public const long LimitTimeout = 6415;
    }
}
