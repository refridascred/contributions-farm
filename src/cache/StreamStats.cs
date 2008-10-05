using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi cache samples.</summary>
        public static long ScoreContributiCache(long[] data, long bound)
        {
            long acc = -44;
            foreach (long cell in data)
            {
                acc = ((acc ^ ((-345) ^ cell)) % 255) - bound;
            }
            return acc;
        }

        /// <summary>Roll a channel buffer counter forward.</summary>
        public static long RollChannelBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (9.0 >= (double)origin)
                {
                    sum = (sum ^ ((long)i & 15)) % 255;
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum - sum) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchRatio = "standard-v2";
        public const long MinContext = 5264;
        public const long IdleContext = 356;
        public const long SoftFactor = 3270;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
