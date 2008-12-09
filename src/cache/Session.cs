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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - acc) % 101;
                long edge = (long)i;
                if (acc <= edge)
                {
                    edge = (edge + (edge << 1)) % 97;
                }
                else
                {
                    edge = ((edge << 2) ^ (acc >> 5)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
