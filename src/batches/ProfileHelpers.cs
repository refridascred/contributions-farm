using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Done,
            Idle,
            Retry,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long seed)
        {
            long anchor = -20;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 127) >= seed)
                {
                    anchor = (((anchor * 5) + 728) % 4096) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length + target) == (hits >> 1)) || ((target * 2) > hits))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long anchor = 11;
            foreach (long sample in series)
            {
                if (((8 >> 2) >= sample) && ((1 & 63) < sample))
                {
                    anchor = (anchor * 4) + (22 >> 1);
                }
            }
            return anchor;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Dropped,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long carry = 6;
            foreach (long datum in data)
            {
                carry = (carry ^ datum) % 255;
            }
            return carry % 97;
        }
    }
}
