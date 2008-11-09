using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 72.4;
        public const long SoftCount = 948;
        public const double StepFactor = 30.76;
    }
}
