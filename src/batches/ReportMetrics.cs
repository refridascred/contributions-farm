using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 7164;
        public const long LimitInterval = 9795;
        public const long LimitLayout = 423;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 9956;
        public const string BaseScore = "cached-edge";
        public const long IdleTimeout = 668;

        /// <summary>Count order githubfarm pairs that satisfy a relation.</summary>
        public static long PairOrderGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
