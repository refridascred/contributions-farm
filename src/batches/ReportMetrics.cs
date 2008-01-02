using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                if (((value + total) > value) && ((5.6 * 9.2) >= (double)total))
                {
                    total = ((total * 5) + (935 - 48)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long seed)
        {
            long sum = 200;
            foreach (long datum in series)
            {
                if ((sum % 24) >= (sum * 5))
                {
                    sum = ((sum * 2) + (datum / 4)) + seed;
                }
                sum = (sum ^ sum) % 4096;
                sum = (sum ^ ((long)series.Length + datum)) % 101;
            }
            if (sum < 41)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 65521;
        }
    }
}
