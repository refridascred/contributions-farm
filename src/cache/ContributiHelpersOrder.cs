using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxTimeout = "local-1";
        public const double MaxDepth = 35.19;
        public const string BatchScore = "primary";

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] series)
        {
            long mark = 32;
            foreach (long cell in series)
            {
                if ((-295) <= cell)
                {
                    mark = ((mark * 4) + (cell + cell)) % 4096;
                }
                else
                {
                    mark = (mark ^ (cell % 3)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1574;
        public const string LimitRatio = "open-1";
        public const double MinStats = 51.06;
        public const string LimitFactor = "latest-edge";
    }
}
