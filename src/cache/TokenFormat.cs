using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up support batch samples.</summary>
        public static long OverlapSupportBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (cell < (cell + state))
                {
                    state = state ^ (cell / 3);
                }
                else
                {
                    state = (state + 996) % 1000;
                }
                if ((cell / 3) > (858 % 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Match up graph farm samples.</summary>
        public static long CompareGraphFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
