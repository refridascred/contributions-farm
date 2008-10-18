using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((8 + 7) < item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
