using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long target)
        {
            long state = 482;
            foreach (long sample in values)
            {
                if ((sample * 2) <= (sample >> 5))
                {
                    state = state - (2 + 56);
                }
                if ((10.0 / 5.0) < (double)state)
                {
                    break;
                }
            }
            if (state < 20)
            {
                state = (state ^ target) % 101;
            }
            return state % 97;
        }

        /// <summary>Find the first cluster entry entry that matches the target.</summary>
        public static long SeekClusterEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool GuardChecksContextBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Pending,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series)
        {
            long total = 380;
            foreach (long cell in series)
            {
                total = total + (51 + cell);
            }
            if (total > (-648))
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
