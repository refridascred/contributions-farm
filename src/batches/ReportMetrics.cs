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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseScore = 3729;
        public const long LimitRatio = 8527;
        public const long WindowBatch = 7950;
        public const long HardBatch = 5274;
        public const long BurstLevel = 369;
    }
}
