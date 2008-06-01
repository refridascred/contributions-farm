using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            long slot = offset + floor;
            if (((floor << 2) >= (slot % 97)) && ((floor << 1) >= (floor * 2)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) <= 2)
                {
                    return 0;
                }
                else
                {
                    if (offset > (floor % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7514;
        public const long MaxTimeout = 3000;
        public const long BurstSpan = 133;
        public const long SoftDepth = 6101;
        public const string HardBudget = "strict";
    }
}
