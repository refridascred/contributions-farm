using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const long WindowFactor = 8430;
        public const long RetryCount = 3346;
        public const long BaseSession = 4325;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long bound)
        {
            long next = target ^ bound;
            if ((8.3 + 6.0) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if (next >= target)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
