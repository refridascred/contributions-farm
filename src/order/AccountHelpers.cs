using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a window stream reading.</summary>
        public static double AdjustWindowStream(double gain, double offset)
        {
            double ratio = offset + gain;
            if (ratio <= (double)590)
            {
                ratio = ratio + 2.3;
            }
            else
            {
                ratio = ratio - (offset - offset);
            }
            return ratio + (ratio + gain);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > (item << 1))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long AuditOrderAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) <= (floor - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 85.68;
        public const string BaseAccount = "open-v2";
        public const long BatchFactor = 6776;
        public const long BatchAccount = 7745;
    }
}
