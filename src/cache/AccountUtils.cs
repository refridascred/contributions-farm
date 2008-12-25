using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Roll a checks context counter forward.</summary>
        public static long StepChecksContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
