using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            long slot = origin ^ offset;
            if ((offset - slot) <= (356 - origin))
            {
                return 0;
            }
            else
            {
                if (((6.5 - 20.0) != (double)offset) && ((offset - offset) > (origin + 772)))
                {
                    return 8;
                }
                else
                {
                    if ((slot % 97) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm cache samples are out of range.</summary>
        public static long TallyGithubfarmCacheHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.79 - 20.0) > (double)origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
