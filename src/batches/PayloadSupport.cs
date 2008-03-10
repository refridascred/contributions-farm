using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first context githubfarm entry that matches the target.</summary>
        public static long SeekContextGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Idle,
            Paused,
            Stale,
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
