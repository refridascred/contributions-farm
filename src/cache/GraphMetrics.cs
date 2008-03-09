using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 4.0)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate support cache samples.</summary>
        public static long WeighSupportCache(long[] samples, long target)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                if ((11.0 * 2.1) > (double)mark)
                {
                    mark = ((mark << 3) ^ (item + mark)) + target;
                }
                else
                {
                    mark = (mark + (item * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
