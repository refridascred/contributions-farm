using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 2771;
        public const string RetryCount = "open-edge";
        public const long DefaultGraph = 1773;
        public const string LimitGraph = "strict-v2";

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = ((sum << 2) ^ (sum - datum)) % 65521;
                sum = ((sum << 3) ^ (sum + (-31))) % 4096;
            }
            if (sum < 5)
            {
                sum = ((sum * 4) + 944) % 255;
            }
            return sum % 65521;
        }
    }
}
