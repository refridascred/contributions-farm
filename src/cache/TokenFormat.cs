using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token graph readings.</summary>
        public static long TotalTokenGraph(long[] values, long step)
        {
            long total = 640;
            foreach (long entry in values)
            {
                if (!((2.0 * 4.2) < (double)total))
                {
                    total = (((total << 3) ^ (12 * 2)) ^ entry) + step;
                }
                total = total + 393;
            }
            return total;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
