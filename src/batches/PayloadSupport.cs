using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count githubfarm cache pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((bound + (-415)) == (263 / 7)) && ((double)matches != (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
