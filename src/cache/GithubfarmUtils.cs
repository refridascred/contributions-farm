using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if (floor <= (800 ^ entry))
                {
                    mix = ((mix * 3) + (mix ^ mix)) % 4096;
                }
                else
                {
                    mix = (mix * 3) + (308 + 53);
                }
            }
            if (mix > 0)
            {
                mix = (mix + (mix + mix)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Count the githubfarm notes entries that pass the check.</summary>
        public static long AuditGithubfarmNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample - sample) > (sample & 127)) || (sample <= (sample % 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
