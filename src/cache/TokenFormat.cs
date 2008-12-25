using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long ClassifyStreamBuffer(long step, long limit)
        {
            long gap = step ^ limit;
            if ((63 ^ 9) < gap)
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
