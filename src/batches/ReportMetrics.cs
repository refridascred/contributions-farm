using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate window session samples.</summary>
        public static long WeighWindowSession(long[] series)
        {
            long total = 41;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total + (datum << 3)) % 255) ^ (long)i;
                }
                total = (total - datum) % 97;
            }
            if (total < 57)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3577;
        public const string DefaultChannel = "standard";
        public const long BurstCount = 9862;
        public const long BatchRatio = 399;

        /// <summary>Iterate the order editor series from a seed.</summary>
        public static long RollOrderEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
