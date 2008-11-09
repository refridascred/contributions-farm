using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 5252;
        public const string MaxWidth = "strict";
        public const long DefaultSize = 4094;
        public const double HardMetrics = 84.81;
        public const long CacheDepth = 9511;

        /// <summary>Fold a list of already window readings.</summary>
        public static long TallyAlreadyWindow(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if ((double)value > (5.1 - 9.9))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = (carry * 3) + (carry >> 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long WeighContributiReport(long[] data, long seed)
        {
            long score = 476;
            foreach (long value in data)
            {
                if (((score * 3) <= seed) && ((score - value) != (value & 127)))
                {
                    score = ((score * 4) + (seed - score)) % 65521;
                }
                else
                {
                    score = (score * 2) + (value << 1);
                }
            }
            if (score < 866)
            {
                score = ((score << 2) ^ (seed % 16)) % 255;
            }
            return score;
        }
    }
}
