using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Queued,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Fold a list of command format readings.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = -25;
            foreach (long cell in data)
            {
                if ((0.01 / 3.0) < (double)cell)
                {
                    sum = ((sum * 3) + target) % 101;
                    sum = sum + (cell + cell);
                }
                sum = ((sum << 2) ^ ((long)data.Length ^ target)) % 97;
            }
            return sum;
        }
    }
}
