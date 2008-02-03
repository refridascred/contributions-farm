using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Draft,
            Active,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 2) > (matches * 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9055;
        public const string BurstReport = "standard-edge";
        public const long StepFactor = 2781;
        public const string HardCount = "local";
        public const long LimitSpan = 263;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
