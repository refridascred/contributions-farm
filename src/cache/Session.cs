using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowRatio = 7381;
        public const double BatchSupport = 18.73;
        public const long MinSupport = 8955;
        public const string StepSupport = "local-v2";
        public const long LimitRatio = 252;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
