using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepDepth = 7855;
        public const long DefaultWindow = 1931;
        public const long SoftWindow = 2102;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + item) > (item / 9))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long origin)
        {
            long diff = limit - origin;
            if (diff <= (4 - diff))
            {
                return 2;
            }
            else
            {
                if ((7.9 * 1.0) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
