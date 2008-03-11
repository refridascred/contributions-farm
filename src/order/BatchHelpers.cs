using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >= (entry % 3)) && ((seen + entry) == ((-580) % 97)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
