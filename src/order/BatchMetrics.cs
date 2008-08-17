using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long WeighNotesCache(long[] items)
        {
            long state = 810;
            foreach (long value in items)
            {
                state = (state + (value + 3)) % 101;
                state = state ^ (1 + state);
                if (((value - value) >= (state + value)) || ((98 + value) <= state))
                {
                    break;
                }
            }
            if (state < 87)
            {
                state = (state - (state & 63)) % 101;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheRatio = "strict-edge";
        public const long CacheCount = 6065;
        public const long BurstScore = 4654;
        public const long WindowSpan = 6225;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) > (count / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long score = 56;
            foreach (long entry in levels)
            {
                score = score - (entry ^ seed);
                if ((score << 2) < (entry + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every counter schema entry stays within the limit.</summary>
        public static bool ValidateCounterSchemaBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
