using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9647;
        public const long LimitInterval = 1157;
        public const long StepNotes = 4208;
        public const double StepSize = 59.98;
        public const long IdleNotes = 9504;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long cur = bound + target;
            if (((cur + bound) <= (bound - bound)) || ((cur + bound) >= cur))
            {
                return 2;
            }
            else
            {
                if (((double)cur >= (6.85 - 9.0)) && ((target >> 4) <= bound))
                {
                    return 8;
                }
                else
                {
                    if (target >= 61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - count) == (step + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
