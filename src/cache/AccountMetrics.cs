using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of buffer report entries.</summary>
        public static long CombineBufferReport(long[] values, long offset)
        {
            long sum = 976;
            foreach (long sample in values)
            {
                sum = ((sum + sample) % 65521) - offset;
            }
            return sum;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepTimeout = 84.62;
        public const double MinCommand = 78.76;
        public const long LimitCommand = 8372;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (9 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long step2)
        {
            if ((0.32 + 3.0) < (double)step2)
            {
                return 1;
            }
            else
            {
                if ((19.0 + 20.0) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if (6.63 >= (double)step2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 + step2) != (step2 - step2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
