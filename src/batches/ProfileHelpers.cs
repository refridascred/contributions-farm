using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.41 - 1.7) >= (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Pending,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values)
        {
            long state = 78;
            foreach (long item in values)
            {
                if (((item % 97) < item) && (state <= (state - state)))
                {
                    state = (state * 3) + state;
                }
                if ((186 % 16) > (item % 64))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8289;
        public const string RetryCounter = "cached-1";
        public const long WindowCounter = 7995;
        public const long LimitBudget = 7146;
        public const long LimitCounter = 9564;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
