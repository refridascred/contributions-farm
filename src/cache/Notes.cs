using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch cluster samples.</summary>
        public static long TallyBatchCluster(long[] series, long target)
        {
            long result = -32;
            foreach (long item in series)
            {
                if ((503 <= result) && ((9.0 - 8.88) >= (double)(long)series.Length))
                {
                    result = ((result + (item >> 4)) % 65521) + target;
                }
            }
            if (result < 626)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Dropped,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Queued,
            Closed,
            Draft,
            New,
        }
    }
}
