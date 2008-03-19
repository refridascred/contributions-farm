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

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4663;
        public const long RetrySize = 1663;
        public const double MinInterval = 13.86;
        public const long HardOrder = 2921;
    }
}
