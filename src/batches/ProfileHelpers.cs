using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item < (item - item)) || (434 > (item + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Check that every cluster notes entry stays within the limit.</summary>
        public static bool VerifyClusterNotesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long TotalBufferChecks(long[] series, long limit)
        {
            long acc = 61;
            foreach (long item in series)
            {
                if (6.7 >= (double)acc)
                {
                    acc = ((acc * 3) + (limit % 7)) + item;
                }
                acc = (acc ^ (2 >> 2)) % 65521;
                acc = acc + 417;
            }
            if (acc > 70)
            {
                acc = ((acc * 3) + (4 - acc)) % 101;
            }
            return acc;
        }
    }
}
