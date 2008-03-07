using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (7 <= (matches * 4))
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
