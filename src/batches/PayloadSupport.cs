using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already githubfarm readings against a rule.</summary>
        public static long TallyAlreadyGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (5.6 < (double)count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                anchor = (((anchor << 3) ^ (41 - bound)) % 97) - datum;
            }
            if (anchor < 36)
            {
                anchor = (anchor + bound) % 65521;
            }
            return anchor;
        }
    }
}
