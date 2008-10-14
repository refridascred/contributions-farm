using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long FoldChecksPayload(long[] readings)
        {
            long sum = 52;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data)
        {
            long result = 769;
            foreach (long sample in data)
            {
                result = (result + (sample >> 2)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long anchor = 32;
            foreach (long item in items)
            {
                if ((double)item != (20.0 - 18.0))
                {
                    anchor = anchor ^ (anchor ^ 3);
                }
                else
                {
                    anchor = (anchor * 2) + 73;
                }
            }
            return anchor;
        }
    }
}
