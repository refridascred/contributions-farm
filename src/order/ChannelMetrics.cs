using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count cluster contributi pairs that satisfy a relation.</summary>
        public static long PairClusterContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order githubfarm samples.</summary>
        public static long CombineOrderGithubfarm(long[] readings, long target)
        {
            long mark = 323;
            foreach (long entry in readings)
            {
                mark = ((mark * 2) + (mark - mark)) % 4096;
                if ((target - entry) >= (mark - entry))
                {
                    mark = (mark ^ (mark % 64)) % 65521;
                }
                else
                {
                    mark = (mark ^ (entry & 7)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
