using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long CountRouteBatchesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((offset - offset) == (offset << 3))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                mix = (mix + 5) % 255;
                if ((sample << 3) <= (mix ^ mix))
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 65521;
        }
    }
}
