using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values, long seed)
        {
            long state = -678;
            foreach (long item in values)
            {
                state = ((((state * 4) + (85 + state)) % 97) ^ item) + seed;
            }
            return state;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long anchor = 103;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (item - (long)samples.Length)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Ready,
            New,
            Idle,
            Done,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long origin)
        {
            long total = 38;
            foreach (long item in samples)
            {
                if (!(item <= (total % 100)))
                {
                    total = (total << 2) ^ (total * 2);
                }
                else
                {
                    total = (total - (total & 63)) % 101;
                }
            }
            if (total < 59)
            {
                total = (total << 2) ^ (origin ^ origin);
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long mark = 23;
            foreach (long value in values)
            {
                mark = (((mark * 5) + mark) % 101) - value;
            }
            return mark;
        }
    }
}
