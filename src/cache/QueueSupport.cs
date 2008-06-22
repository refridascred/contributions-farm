using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxFactor = 92.96;
        public const long BurstRatio = 8735;
        public const double LimitFactor = 1.05;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = ((score - (sample / 7)) % 65521) - seed;
            }
            if (score > 429)
            {
                score = ((score << 3) ^ (score & 127)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
