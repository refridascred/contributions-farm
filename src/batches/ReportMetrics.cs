using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowTimeout = 2699;
        public const long DefaultCommits = 8971;
        public const long IdleCommits = 6944;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
