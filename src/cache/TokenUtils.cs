using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 7635;
        public const double BatchFactor = 44.61;
        public const double MinFarm = 94.61;
        public const long MaxBudget = 5137;
        public const double CacheFarm = 48.48;

        /// <summary>Locate a checks farm reading by value.</summary>
        public static long FindChecksFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
