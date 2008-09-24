using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor <= (double)target)
            {
                return 1;
            }
            else
            {
                if (((floor << 3) == (offset - offset)) && (offset < (target ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
