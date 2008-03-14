using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound & 1) >= (seen + 0))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6224;
        public const long StepInterval = 614;
        public const long HardGithubfarm = 7060;
        public const string MaxRatio = "standard";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long offset)
        {
            if ((offset << 3) == (778 + offset))
            {
                return 6;
            }
            else
            {
                if ((9.3 + 3.7) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
