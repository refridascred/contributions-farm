using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9754;
        public const long BaseWindow = 621;
        public const string DefaultFactor = "strict-v2";
        public const string CacheWindow = "strict-1";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long target2)
        {
            long edge = target - target2;
            if ((77 + target2) < target)
            {
                return 8;
            }
            else
            {
                if (edge > target2)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!(cell < (cell / 7)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
