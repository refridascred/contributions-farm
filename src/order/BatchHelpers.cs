using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stream graph value.</summary>
        public static double AdjustStreamGraph(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (offset - ratio))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + (double)83;
        }
    }
}
