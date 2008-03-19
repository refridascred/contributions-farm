using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next context batches value from a seed.</summary>
        public static long StepContextBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + 30;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of support metrics entries.</summary>
        public static long FoldSupportMetrics(long[] readings)
        {
            long score = 22;
            foreach (long sample in readings)
            {
                if ((440 ^ score) != (sample - sample))
                {
                    score = (score - (88 & 127)) % 255;
                }
                else
                {
                    score = score - 43;
                }
                if (sample < (long)readings.Length)
                {
                    break;
                }
            }
            if (score < 795)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 5396;
        public const string LimitFarm = "latest-v2";
        public const long BatchFarm = 9258;
        public const long WindowWidth = 951;
        public const long WindowFarm = 1690;
    }
}
