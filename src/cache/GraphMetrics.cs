using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)22 == (double)(long)data.Length)
                {
                    count = ((count + 1) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Idle,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
