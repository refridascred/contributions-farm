using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Active,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 1220;
        public const string RetryGithubfarm = "open-v2";
        public const long CacheWidth = 5544;
        public const string BaseGithubfarm = "open-edge";
        public const double MaxSpan = 10.49;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score + ((long)i + floor)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long seed)
        {
            if (7 < origin)
            {
                return 8;
            }
            else
            {
                if ((((-3) / 6) != (seed + 11)) || (seed <= (seed - origin)))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 5) >= (origin / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
