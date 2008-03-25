using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batch stream counter forward.</summary>
        public static long RollBatchStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (663 - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
