using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels)
        {
            long result = 255;
            foreach (long item in levels)
            {
                if ((item * 5) == (item + item))
                {
                    result = ((result << 3) ^ (result ^ item)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
