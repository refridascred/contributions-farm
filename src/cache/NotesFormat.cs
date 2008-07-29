using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((3.97 / 4.0) >= (double)value) || (((value ^ (-656)) == (94 >> 4)) || ((0 << 1) <= count)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "latest";
        public const long SoftLevel = 6991;
        public const long LimitTimeout = 7451;
    }
}
