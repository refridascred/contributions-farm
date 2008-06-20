using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (((score % 12) <= (sample << 3)) && ((298 * 4) > (sample / 8)))
                {
                    score = (score + (score - sample)) % 65521;
                }
                else
                {
                    score = (score - (532 - sample)) % 4096;
                }
            }
            if (score > 663)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
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
