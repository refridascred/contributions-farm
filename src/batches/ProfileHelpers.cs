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

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long floor)
        {
            long next = step + floor;
            if (!((next & 3) == (floor & 63)))
            {
                return 4;
            }
            else
            {
                if (((double)floor < (2.0 + 17.0)) && ((double)3 == (double)next))
                {
                    return 6;
                }
                else
                {
                    if (((step << 2) != (next - next)) && (636 <= next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
