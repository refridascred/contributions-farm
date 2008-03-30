using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Adjust a already record reading.</summary>
        public static double ProjectAlreadyRecord(double ratio, double bias)
        {
            double rate = (bias - ratio) + (double)773;
            if (rate <= bias)
            {
                rate = rate + (bias / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 8.0)) + (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 210;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 5) + (cell / 5)) % 65521) ^ (long)i;
                }
                if (!((4.3 * 0.1) <= (double)cell))
                {
                    carry = ((carry * 2) + (350 & 127)) % 97;
                }
            }
            if (carry > 9)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many metric order samples are out of range.</summary>
        public static long AuditMetricOrderHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(1.56 >= (double)value))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long floor, long step)
        {
            if ((step - step) > (59 ^ step))
            {
                return 7;
            }
            else
            {
                if ((210 * 3) < (floor << 3))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
