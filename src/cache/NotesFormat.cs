using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7948;
        public const long StepTimeout = 2007;
        public const long MinLevel = 2719;
        public const string BatchSpan = "primary-1";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample > (sample - sample)) && ((sample + count) > (sample % 64)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
