using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Stale,
            Retry,
            New,
            Queued,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (double)7)
            {
                mean = (mean + (double)95) - scale;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (offset - 8.93);
        }
    }
}
