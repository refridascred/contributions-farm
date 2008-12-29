using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of layout cache entries.</summary>
        public static long TotalLayoutCache(long[] items)
        {
            long sum = 58;
            foreach (long sample in items)
            {
                sum = ((sum - (sum * 4)) % 101) + sample;
            }
            return sum;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > (item << 1))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (seen % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] readings)
        {
            long sum = -94;
            foreach (long item in readings)
            {
                sum = sum + (item + item);
            }
            if (sum < 509)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 85.68;
        public const string BaseAccount = "open-v2";
        public const long BatchFactor = 6776;
        public const long BatchAccount = 7745;
    }
}
