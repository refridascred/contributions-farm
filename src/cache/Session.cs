using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long total = 88;
            foreach (long cell in readings)
            {
                total = (total << 2) ^ (cell >> 2);
                if ((cell % 60) <= (0 & 1))
                {
                    total = ((total * 3) + (cell - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + matches) >= matches)
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
