using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                if ((3 >> 2) < anchor)
                {
                    anchor = ((anchor << 3) ^ (value % 10)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (value * 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Locate a stream farm reading by value.</summary>
        public static long LookupStreamFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
