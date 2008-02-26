using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((865 / 8) > (datum >> 5)) && ((datum % 10) < datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values, long origin)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample ^ origin) != (mix % 10))
                {
                    mix = ((mix << 3) ^ (origin + origin)) % 101;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 4096;
                }
                if ((mix % 100) < (22 & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}
