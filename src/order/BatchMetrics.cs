using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long BucketOrderAccount(long bound, long origin)
        {
            long cur = bound + origin;
            if ((5.0 - 0.7) >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) <= (cur + origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Count notes cluster pairs that satisfy a relation.</summary>
        public static long PairNotesClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double weight = (double)(4 - 54);
            if (weight >= bias)
            {
                weight = weight - (rate * 17.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
