using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of contributi cluster entries.</summary>
        public static long WeighContributiCluster(long[] data, long origin)
        {
            long acc = 966;
            foreach (long entry in data)
            {
                if (!!(acc <= entry))
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 97;
                }
                acc = ((acc * 3) + (origin % 60)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry + 282)) % 4096;
                if (!(carry > (origin * 5)))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
