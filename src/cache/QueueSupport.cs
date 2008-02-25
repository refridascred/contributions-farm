using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long DigestBufferRoute(long[] levels)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                carry = (carry + (carry + 75)) - entry;
                carry = (carry ^ ((long)levels.Length - 67)) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (cell & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first batch contributi entry that matches the target.</summary>
        public static long FindBatchContributiIndex(long[] values, long target)
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
    }
}
