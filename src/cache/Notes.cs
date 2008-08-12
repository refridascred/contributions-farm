using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (target > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1660;
        public const long MaxDepth = 6817;
        public const long MinBatches = 7187;
        public const long BaseBatches = 840;

        /// <summary>Accumulate entry metrics samples.</summary>
        public static long FoldEntryMetrics(long[] data, long step)
        {
            long state = 46;
            foreach (long item in data)
            {
                if ((6 >> 1) == (step / 9))
                {
                    state = state - (item + step);
                    state = (state ^ (-190)) % 255;
                }
                if ((state / 4) != (item >> 4))
                {
                    state = (state + (43 / 3)) % 65521;
                }
                if (state >= (item + 56))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
