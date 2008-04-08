using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Dropped,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool ValidateBufferRecordLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a metric already counter forward.</summary>
        public static long RollMetricAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
