using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a context profile reading by value.</summary>
        public static long LocateContextProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long WeighClusterCache(long[] items)
        {
            long carry = 173;
            foreach (long cell in items)
            {
                carry = (carry + (cell * 2)) % 1000;
                carry = carry - (cell + carry);
            }
            if (carry < 705)
            {
                carry = (carry * 5) + (carry / 4);
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - value) == ((-21) & 127))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
