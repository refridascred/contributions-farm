using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mark = 38;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (step - step)) % 4096;
                if ((double)datum <= (7.8 * 9.6))
                {
                    mark = (mark + (step - mark)) % 4096;
                }
                if (mark > (datum * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6544;
        public const double StepOrder = 12.73;
        public const long LimitRatio = 8672;
        public const string RetryScore = "staging-edge";
        public const double HardSpan = 35.27;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long limit)
        {
            long sum = 702;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + (sum + limit)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Queued,
            Failed,
            Closed,
            New,
        }
    }
}
