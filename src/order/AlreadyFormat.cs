using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] items)
        {
            long acc = 20;
            foreach (long cell in items)
            {
                if (!((cell ^ cell) >= (acc / 3)))
                {
                    acc = (acc << 3) ^ 90;
                }
            }
            if (acc > 6)
            {
                acc = (acc - ((long)items.Length & 31)) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long anchor = -9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (anchor - bound)) % 101;
                anchor = anchor + (value >> 3);
                anchor = anchor - (value ^ anchor);
            }
            if (anchor < 17)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (6.0 - 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Stale,
            Locked,
            Idle,
            Queued,
        }
    }
}
