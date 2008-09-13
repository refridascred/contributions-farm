using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 56;
            foreach (long datum in levels)
            {
                score = ((score * 3) + (datum ^ 2)) % 1000;
            }
            if (score > 8)
            {
                score = (score - ((-11) >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "strict-1";
        public const long SoftRecord = 1742;
        public const long WindowRecord = 9583;
        public const double MaxRecord = 32.51;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long total = 537;
            foreach (long value in readings)
            {
                if (!((935 - (-98)) <= total))
                {
                    total = ((total << 2) ^ total) % 4096;
                    total = ((total * 2) + total) % 65521;
                }
                if ((value - value) <= total)
                {
                    total = ((total * 4) + (total >> 4)) % 101;
                }
                if (((2.7 / 6.0) == (double)value) || ((3.07 - 2.09) > (double)value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound * 5) < bound)
                {
                    mark = ((mark * 2) + bound) % 65521;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 68.87;
        public const long WindowFarm = 3191;
        public const long BurstFarm = 7888;
    }
}
