using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 6568;
        public const string WindowSession = "open-1";
        public const double RetrySession = 16.91;

        /// <summary>Roll a farm support counter forward.</summary>
        public static long StepFarmSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ target) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 1452;
        public const string StepGraph = "legacy";
        public const string MaxRatio = "latest";
        public const long DefaultGraph = 536;
        public const long BatchGraph = 1025;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
