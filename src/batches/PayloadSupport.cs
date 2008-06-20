using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((target / 3) <= reading) || (count >= reading)) && ((reading * 5) <= target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values)
        {
            long result = 88;
            foreach (long datum in values)
            {
                if ((77 <= (result + datum)) && (result < datum))
                {
                    result = (result - (result & 1)) % 101;
                }
            }
            return result;
        }
    }
}
