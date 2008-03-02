using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate counter order samples.</summary>
        public static long FoldCounterOrder(long[] data)
        {
            long mix = 3;
            foreach (long value in data)
            {
                if ((value / 4) < mix)
                {
                    mix = (mix - (value % 12)) % 4096;
                }
                if (((value ^ value) <= mix) || ((7.85 - 6.93) < (double)value))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "staging";
        public const string SoftWindow = "primary";
        public const long LimitSize = 8465;
        public const double BatchWindow = 23.61;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell >> 5) >= (tally ^ 5)) && ((cell <= (6 * 5)) && (tally < (bound / 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long CombineQueueStats(long[] values, long bound)
        {
            long sum = 294;
            foreach (long entry in values)
            {
                if ((bound - sum) <= (sum ^ entry))
                {
                    sum = sum ^ (sum ^ 23);
                }
                else
                {
                    sum = sum - (bound / 7);
                }
                if ((entry << 1) > ((-4) % 100))
                {
                    break;
                }
            }
            if (sum > 61)
            {
                sum = (sum * 3) + (2 - bound);
            }
            return sum;
        }
    }
}
