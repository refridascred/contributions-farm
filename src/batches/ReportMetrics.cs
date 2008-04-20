using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels, long seed)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                if ((seed - result) > (seed * 2))
                {
                    result = (result << 3) ^ result;
                }
                if ((52 + seed) == (entry >> 5))
                {
                    result = result - (613 / 9);
                }
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Locked,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
