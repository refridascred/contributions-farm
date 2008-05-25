using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 409;
        public const long StepReport = 8598;
        public const double MaxLevel = 81.87;
        public const long BatchCount = 584;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "staging-1";
        public const long BatchSize = 4028;
        public const string MinCount = "legacy-1";
        public const long SoftDepth = 3549;
        public const double MinCluster = 59.44;
    }
}
