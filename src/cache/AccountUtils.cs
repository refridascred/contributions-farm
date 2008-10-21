using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 - (ratio * 8.09)) - (double)(long)i) - span;
            }
            return ratio2 + 6.0;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
