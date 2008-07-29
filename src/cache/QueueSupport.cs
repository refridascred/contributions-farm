using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long acc = 370;
            foreach (long cell in series)
            {
                if (!((acc + 50) < step))
                {
                    acc = acc ^ (cell / 7);
                }
            }
            if (acc > 122)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardDepth = "open-v2";
        public const long MinSpan = 7946;
        public const long MaxBatch = 7865;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = (drift + drift) + scale;
            }
            return drift - (floor - drift);
        }
    }
}
