using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5531;
        public const string IdleSupport = "stable-v2";
        public const long BaseSupport = 6223;
        public const double SoftSupport = 29.43;
        public const long BatchBudget = 1002;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ (item - 16)) % 97;
                acc = (acc ^ (acc + bound)) % 4096;
                if ((8.0 / 3.0) == (double)item)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc << 2) ^ (21 - (long)readings.Length);
            }
            return acc;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long target)
        {
            long sum = 705;
            foreach (long cell in series)
            {
                if ((double)sum > (9.3 * 8.4))
                {
                    sum = (sum << 3) ^ (target << 3);
                }
                else
                {
                    sum = (sum - (target + cell)) % 1000;
                }
            }
            if (sum > 9)
            {
                sum = (sum * 4) + (sum ^ target);
            }
            return sum;
        }
    }
}
