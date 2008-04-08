using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long target)
        {
            long total = 39;
            foreach (long datum in data)
            {
                total = ((total - (datum + 82)) % 4096) - target;
            }
            return total % 97;
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
