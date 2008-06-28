using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                if (!!((double)(long)i >= (8.4 / 8.0)))
                {
                    score = ((score * 4) + score) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Dropped,
            Active,
        }
    }
}
