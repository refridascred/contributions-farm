using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if ((target ^ 789) <= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (target > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1926;
        public const long RetryOrder = 7616;
        public const string SoftOrder = "open-edge";
        public const string WindowOrder = "primary-v2";
        public const long DefaultCount = 3299;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values)
        {
            long total = 490;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ 0) % 4096;
                if ((datum - datum) > (datum % 97))
                {
                    total = ((total << 2) ^ (total >> 3)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (datum ^ datum)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (count >> 5))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
