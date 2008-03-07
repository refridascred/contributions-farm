using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + weight2) + weight;
        }
    }
}
