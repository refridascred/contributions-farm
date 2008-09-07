using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!!((6.24 + 11.0) <= (double)result))
                {
                    result = (result - (bound + bound)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
