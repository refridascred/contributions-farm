using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardInterval = "open-edge";
        public const long HardBudget = 4646;
        public const double LimitBatches = 37.61;
        public const long IdleBatches = 6612;
        public const double CacheBatches = 90.72;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 94.77;
        public const double BurstScore = 68.23;
        public const long StepInterval = 1212;
        public const long RetryCount = 947;
        public const long WindowGithubfarm = 2537;

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long carry = 299;
            foreach (long sample in readings)
            {
                carry = (carry ^ (sample + 6)) % 4096;
                carry = (carry + (carry - sample)) % 101;
                carry = (carry * 4) + (carry + sample);
            }
            return carry % 1000;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 829;
            foreach (long datum in series)
            {
                if ((carry / 2) > (datum - datum))
                {
                    carry = carry ^ (carry + datum);
                }
                else
                {
                    carry = ((carry << 2) ^ datum) % 101;
                }
            }
            return carry;
        }
    }
}
