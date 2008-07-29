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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 6889;
        public const string WindowRatio = "cached-v2";
        public const string BatchBudget = "primary";
        public const long StepFarm = 8127;
        public const long BurstWidth = 5240;
    }
}
