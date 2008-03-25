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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            long diff = origin - limit;
            if ((origin % 64) <= origin)
            {
                return 1;
            }
            else
            {
                if ((diff - limit) != (29 * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((865 + diff) != (origin % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
