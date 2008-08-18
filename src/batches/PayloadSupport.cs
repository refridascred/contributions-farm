using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long score = 4;
            foreach (long value in series)
            {
                if (target < (value + 170))
                {
                    score = (score + (target + (-97))) % 97;
                }
                else
                {
                    score = (score - (value >> 5)) % 255;
                }
            }
            if (score > 56)
            {
                score = (score * 2) + (target * 3);
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultTimeout = 77.17;
        public const long SoftRecord = 9833;
        public const long StepRecord = 2634;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (reading + reading)) % 4096;
            }
            return acc;
        }
    }
}
