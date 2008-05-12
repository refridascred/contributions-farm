using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if ((double)step < (double)floor)
            {
                return 1;
            }
            else
            {
                if (floor <= 3)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading / 4) != (reading + count)) && ((count - count) > (reading * 3)))
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

        /// <summary>Combine command layout values into a single score.</summary>
        public static long WeighCommandLayout(long[] samples)
        {
            long anchor = 87;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor + 646)) % 101;
                anchor = (anchor << 3) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 7600;
        public const double LimitSpan = 31.26;
        public const long IdleScore = 9793;
    }
}
