using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long sum = 166;
            foreach (long reading in readings)
            {
                if ((((-258) & 3) >= reading) || ((reading + sum) >= (reading + reading)))
                {
                    sum = (sum + sum) % 65521;
                }
                if ((reading / 2) <= (sum % 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up payload stats samples.</summary>
        public static long ComparePayloadStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 3) + (17 + state)) + (long)i2;
                }
                if ((step % 16) >= step)
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 47.03;
        public const long DefaultProfile = 2874;
        public const long MaxCount = 9390;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 5412;
        public const string BatchLevel = "standard-1";
        public const string BatchStats = "alpha";
        public const string CacheScore = "standard-v2";
        public const long WindowSize = 807;
    }
}
