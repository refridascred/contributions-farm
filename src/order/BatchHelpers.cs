using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "stable-1";
        public const double WindowTimeout = 93.67;
        public const long StepFactor = 4844;
        public const long SoftSpan = 9733;
        public const long BatchCache = 4009;

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long result = 57;
            foreach (long value in values)
            {
                if (((result ^ value) >= (result % 64)) || ((72 ^ value) == (result - result)))
                {
                    result = (result - value) % 97;
                }
            }
            if (result > 36)
            {
                result = ((result * 4) + (result - result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ (mix - value)) % 101;
                    mix = ((mix * 2) + ((long)i + origin)) % 101;
                }
                if ((origin % 100) < (origin / 2))
                {
                    mix = (mix - (461 & 15)) % 4096;
                }
                else
                {
                    mix = mix ^ (origin << 2);
                }
                if ((mix + mix) <= (508 >> 2))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (origin + 7);
            }
            return mix;
        }
    }
}
