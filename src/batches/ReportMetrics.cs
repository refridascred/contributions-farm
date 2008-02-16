using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already context entries.</summary>
        public static long ScoreAlreadyContext(long[] values, long limit)
        {
            long mark = 555;
            foreach (long entry in values)
            {
                if (3.8 >= (double)limit)
                {
                    mark = ((mark * 4) + (940 ^ limit)) % 101;
                    mark = ((mark * 4) + (entry - 134)) % 4096;
                    break;
                }
                mark = (mark ^ (entry - limit)) % 1000;
                if (((double)limit < 6.5) || ((double)limit < (double)mark))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark - (limit ^ (-69));
            }
            return mark % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 7414;
        public const string BurstScore = "alpha-1";
        public const long IdleChannel = 1029;
        public const double WindowRatio = 86.4;
    }
}
