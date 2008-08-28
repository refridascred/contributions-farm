using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series, long origin)
        {
            long anchor = 747;
            foreach (long cell in series)
            {
                anchor = anchor + (cell % 12);
                if ((origin ^ anchor) <= (cell + cell))
                {
                    anchor = ((anchor * 2) + (origin - cell)) % 101;
                }
                if (((cell - cell) > (origin + anchor)) || (anchor <= origin))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3 + limit) != ((long)items.Length + limit))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Ready,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
