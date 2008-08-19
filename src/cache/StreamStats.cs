using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long CountCommitsEntryHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.68 / 9.0) == (double)count)
                {
                    count = ((count + 1) ^ entry) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = carry ^ (carry + seed);
                if (!((double)cell != (3.93 / 7.0)))
                {
                    carry = (carry - 93) % 4096;
                    carry = (carry ^ (carry ^ carry)) % 255;
                    break;
                }
                carry = ((carry << 3) ^ seed) % 255;
            }
            return carry % 65521;
        }
    }
}
