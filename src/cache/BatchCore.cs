using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) < (tally ^ sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxTimeout = "latest-1";
        public const double IdleBudget = 85.25;
        public const double MinReport = 52.22;
        public const string BurstTimeout = "latest-1";

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long sum = 111;
            foreach (long value in values)
            {
                if ((double)value < 8.74)
                {
                    sum = ((sum * 4) + (57 >> 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Pending,
            New,
            Ready,
            Paused,
        }
    }
}
