using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double load = offset;
            if (load >= 0.6)
            {
                load = (load + load) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (double)65;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "staging-v2";
        public const double IdleFactor = 5.64;
        public const long LimitLevel = 3941;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
