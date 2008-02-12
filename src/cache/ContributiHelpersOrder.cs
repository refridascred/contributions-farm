using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (((92 - reading) >= (-1)) && ((result + (long)samples.Length) < (result + result)))
                {
                    result = (result << 3) ^ (44 - reading);
                }
                else
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
