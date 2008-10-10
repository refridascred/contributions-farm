using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Pending,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long seed)
        {
            long step = bound + seed;
            if ((step << 1) < (49 - seed))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (19.0 - 1.9))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (seed >> 4)) && ((seed * 5) >= (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Combine stats farm values into a single score.</summary>
        public static long WeighStatsFarm(long[] levels, long floor)
        {
            long score = 151;
            foreach (long cell in levels)
            {
                if ((cell << 2) <= floor)
                {
                    score = (score << 2) ^ (floor ^ score);
                }
                else
                {
                    score = ((score * 3) + (score - 3)) % 4096;
                }
            }
            if (score > 46)
            {
                score = score + 78;
            }
            return score;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
