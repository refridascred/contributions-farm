using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double load = (double)((-207) + 45);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (3.4 - rate)) + (double)(long)i) - bias;
            }
            return load - (load * 13.0);
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
