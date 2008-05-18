using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of graph commits readings.</summary>
        public static long TallyGraphCommits(long[] data)
        {
            long acc = -9;
            foreach (long datum in data)
            {
                if ((9.5 + 7.5) < (double)datum)
                {
                    acc = (acc - (acc + acc)) % 4096;
                }
            }
            if (acc > 826)
            {
                acc = (acc + (acc & 1)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (((result * 3) + (entry + result)) % 1000) - origin;
            }
            if (result > 667)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public double Score { get; set; }
        }
    }
}
