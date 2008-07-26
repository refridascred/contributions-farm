using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((double)count < (6.4 - 14.0)))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
        }

        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((bound ^ entry) < (seen + bound))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool GuardBatchesAlreadyLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long WeighChannelPayload(long[] data)
        {
            long carry = -1;
            foreach (long entry in data)
            {
                carry = ((carry * 3) + entry) % 101;
                carry = (carry << 3) ^ 105;
                if (!((double)carry > (8.51 * 5.5)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
