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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long bound)
        {
            long result = 886;
            foreach (long reading in data)
            {
                if ((20.0 / 8.0) > (double)reading)
                {
                    result = (result + reading) - bound;
                }
                if (18 >= reading)
                {
                    break;
                }
            }
            if (result > 959)
            {
                result = (result - (result << 2)) % 97;
            }
            return result;
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
