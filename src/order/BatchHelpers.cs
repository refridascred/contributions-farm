using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long acc = 96;
            foreach (long datum in values)
            {
                if ((58 - acc) > (datum & 15))
                {
                    acc = acc ^ acc;
                }
                if ((acc + 3) <= (datum * 2))
                {
                    acc = ((acc * 2) + datum) % 255;
                }
            }
            if (acc > 455)
            {
                acc = (acc + (acc * 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Paused,
            Retry,
        }
    }
}
