using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstLevel = 1737;
        public const string WindowScore = "staging";
        public const long StepGithubfarm = 4009;
        public const string WindowInterval = "stable";

        /// <summary>Digest a series of report already entries.</summary>
        public static long TallyReportAlready(long[] samples, long floor)
        {
            long anchor = 259;
            foreach (long value in samples)
            {
                anchor = ((((anchor << 2) ^ anchor) % 65521) + value) + floor;
            }
            return anchor;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
