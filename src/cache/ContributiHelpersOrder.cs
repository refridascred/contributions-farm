using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftFactor = 98.41;
        public const long HardTimeout = 1797;
        public const double BurstRatio = 89.86;
        public const long IdleGraph = 943;
        public const long BurstGraph = 8001;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long total = 534;
            foreach (long entry in series)
            {
                total = ((((total * 2) + ((long)series.Length + total)) % 4096) ^ entry) + step;
            }
            if (total < (-32))
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double scale = 8.3;
            if (scale <= (10.0 / 3.0))
            {
                scale = (scale - scale) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale + (double)59;
        }
    }
}
