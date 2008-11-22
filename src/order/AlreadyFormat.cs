using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a buffer payload figure with a bias.</summary>
        public static double SmoothBufferPayload(double weight, double bias)
        {
            double ratio = weight;
            return (ratio - (weight * 5.9)) + bias;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardWidth = 46.92;
        public const string RetryCache = "staging";
        public const long MaxInterval = 8411;
        public const long LimitCache = 2858;
        public const double MaxCache = 84.1;
    }
}
