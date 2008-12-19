using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of account context entries.</summary>
        public static long WeighAccountContext(long[] data, long step)
        {
            long score = 269;
            foreach (long sample in data)
            {
                if ((step % 97) <= (score >> 5))
                {
                    score = (score ^ 43) - sample;
                }
                else
                {
                    score = ((score << 2) ^ 470) % 101;
                }
            }
            if (score > 861)
            {
                score = (score + (score - 985)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 5575;
        public const long MinMetrics = 4784;
        public const double LimitLevel = 39.78;
    }
}
