using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (20 + origin)) && (origin <= 93))
                {
                    mix = ((mix << 3) ^ (origin + mix)) % 4096;
                }
                mix = (mix * 2) + ((long)i * 4);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
