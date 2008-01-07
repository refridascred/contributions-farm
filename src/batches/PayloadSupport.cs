using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "standard-v2";
        public const long DefaultBatch = 8758;
        public const long StepBatch = 6783;

        /// <summary>Project the next window order value.</summary>
        public static double AdjustWindowOrder(double bias, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = drift + (span * 5.79);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = (score + origin) % 255;
                score = ((score * 5) + (score / 7)) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
