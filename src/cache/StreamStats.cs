using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Locked,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long offset)
        {
            if (!((8.4 / 4.0) != (double)step))
            {
                return 7;
            }
            else
            {
                if ((345 - offset) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item ^ seen) > (seen << 2)) || ((origin / 6) > (seen - origin)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
