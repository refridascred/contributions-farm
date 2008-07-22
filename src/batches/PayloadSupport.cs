using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items, long floor)
        {
            long total = 94;
            foreach (long sample in items)
            {
                total = ((total - (44 >> 4)) - sample) - floor;
            }
            return total;
        }

        /// <summary>Count report checks pairs that satisfy a relation.</summary>
        public static long CompareReportChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound << 2) < seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
