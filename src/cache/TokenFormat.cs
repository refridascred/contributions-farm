using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((bound - 33) < (floor % 60))
            {
                return 0;
            }
            else
            {
                if (((double)bound < 5.36) || ((2 + floor) < bound))
                {
                    return 2;
                }
                else
                {
                    if (3.89 <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
