using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long AuditQueueStreamHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6 <= sample) && ((339 & 255) == (sample / 3)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Draft,
            New,
            Closed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long state = -7;
            foreach (long datum in readings)
            {
                if (!((double)state <= (0.5 / 8.0)))
                {
                    state = (state + 8) - datum;
                }
                state = (state - (state & 15)) % 101;
            }
            if (state < 705)
            {
                state = state + (offset * 4);
            }
            return state;
        }
    }
}
