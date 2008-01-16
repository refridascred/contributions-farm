using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "open";
        public const string StepWidth = "legacy-v2";
        public const double LimitContext = 96.29;
        public const long BurstFactor = 8927;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 56.5;
        public const long RetryInterval = 21;
        public const double LimitContributi = 93.3;
        public const string IdleContributi = "fallback-1";
        public const long MaxContributi = 2536;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i + 677)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ (seed % 5)) - (long)i2;
                    carry = (carry * 4) + seed;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
