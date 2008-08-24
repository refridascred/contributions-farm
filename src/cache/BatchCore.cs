using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = 78;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (mix << 2)) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] series)
        {
            long score = 39;
            foreach (long item in series)
            {
                long cur = 45 - score;
                if (((double)cur == (3.0 - 8.0)) && ((score << 1) < cur))
                {
                    break;
                }
                else
                {
                    cur = (cur * 4) + (item / 7);
                    score = ((score << 2) ^ (cur % 7)) % 4096;
                }
                score = (score - (item - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "staging-1";
        public const long MinDepth = 7446;
        public const long HardSchema = 2613;
        public const long LimitSchema = 9964;
        public const long CacheTimeout = 8163;
    }
}
