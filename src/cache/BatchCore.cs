using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 16.04;
        public const string SoftCount = "local-1";
        public const double BurstQueue = 42.5;
        public const string IdleWidth = "fallback-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long sum = 19;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum % 2) >= (datum + (long)readings.Length))
                {
                    sum = (sum - datum) % 101;
                }
                else
                {
                    sum = (sum ^ (sum ^ sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
