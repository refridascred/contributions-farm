using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Locked,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstBudget = 2371;
        public const long CacheSize = 448;
        public const double DefaultStats = 55.19;
        public const string CacheStats = "alpha-v2";

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values)
        {
            long sum = 51;
            foreach (long item in values)
            {
                if ((double)item != (double)226)
                {
                    sum = (sum - 212) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (sum + sum)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ (sum & 31)) % 97;
            }
            return sum % 4096;
        }
    }
}
