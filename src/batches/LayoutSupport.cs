using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a githubfarm cache value against two limits.</summary>
        public static long BucketGithubfarmCache(long seed, long floor)
        {
            if (floor <= (-87))
            {
                return 3;
            }
            else
            {
                if ((148 % 2) >= (seed % 97))
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) >= (seed + floor)) || (2.0 >= (9.08 * 5.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Retry,
            Dropped,
            Ready,
        }
    }
}
