using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "alpha";
        public const long BaseSize = 4679;
        public const long WindowGraph = 869;
        public const long LimitGraph = 5422;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 6846;
        public const long BurstLayout = 4195;
        public const long SoftCount = 7497;
        public const long HardLayout = 4320;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum * 4) <= (datum - datum))
                {
                    total = (total << 2) ^ (86 - total);
                }
            }
            if (total > (-3))
            {
                total = ((total * 3) + (total / 7)) % 97;
            }
            return total;
        }
    }
}
