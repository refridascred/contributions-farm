using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first commits command entry that matches the target.</summary>
        public static long LocateCommitsCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long score = 83;
            foreach (long entry in samples)
            {
                score = (score + (0 % 2)) % 255;
                if (!((5.5 + 17.0) >= (double)score))
                {
                    score = score + (entry / 9);
                }
            }
            if (score < 430)
            {
                score = score - score;
            }
            return score % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8440;
        public const string HardRoute = "staging-edge";
        public const long SoftRoute = 3392;
        public const long MinFactor = 5924;
    }
}
