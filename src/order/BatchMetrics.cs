using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Find the first stream channel entry that matches the target.</summary>
        public static long SeekStreamChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 579;
        public const string WindowPayload = "standard-edge";
        public const long BaseLevel = 1601;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + mark;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
