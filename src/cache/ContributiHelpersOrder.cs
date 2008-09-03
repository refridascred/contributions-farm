using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((step ^ step) != (gap % 10))
            {
                return 1;
            }
            else
            {
                if (((-293) ^ step) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-7)) >= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ 83) != (9 >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
