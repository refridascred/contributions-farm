using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstFactor = "strict-1";
        public const string MaxFactor = "staging";
        public const string CacheBudget = "staging-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= (floor ^ score))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
