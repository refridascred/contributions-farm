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

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up window metrics samples.</summary>
        public static long OverlapWindowMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ target) % 101;
                mark = (mark - (mark * 3)) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
