using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = ((carry << 2) ^ (8 - sample)) % 4096;
            }
            if (carry > 632)
            {
                carry = (carry + (carry / 9)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - matches) <= (221 + matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
