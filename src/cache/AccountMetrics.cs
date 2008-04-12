using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long target2)
        {
            if ((target ^ target) != (target % 64))
            {
                return 3;
            }
            else
            {
                if ((target - 836) >= (target2 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry & 255) == (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-966) << 1) < (datum >> 1))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 8205;
        public const long SoftSize = 6485;
        public const long BatchSpan = 4481;
        public const double StepInterval = 63.65;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
