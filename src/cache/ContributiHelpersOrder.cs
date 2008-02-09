using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long FoldOrderCluster(long[] data)
        {
            long sum = 29;
            foreach (long entry in data)
            {
                if (sum <= (24 * 5))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5923;
        public const double HardSupport = 44.64;
        public const long MaxInterval = 7538;
        public const long SoftSupport = 6348;
        public const double SoftInterval = 9.05;
    }
}
