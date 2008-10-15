using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.6 * 1.0) > (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long offset)
        {
            if (!((offset - offset) <= (offset & 127)))
            {
                return 0;
            }
            else
            {
                if (3.15 < (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
