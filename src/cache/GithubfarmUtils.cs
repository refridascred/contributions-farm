using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) < (entry + matches)) && ((7.02 - 0.9) < (double)matches)) || ((double)matches < (7.0 + 3.0)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
