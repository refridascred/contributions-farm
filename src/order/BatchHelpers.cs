using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
