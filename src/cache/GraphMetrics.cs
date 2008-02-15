using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 668;
            foreach (long item in values)
            {
                state = ((state * 2) + state) + item;
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                acc = ((acc - (137 << 2)) % 4096) ^ reading;
            }
            return acc;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
