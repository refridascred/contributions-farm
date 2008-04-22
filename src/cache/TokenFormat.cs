using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (bound + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2825;
        public const string BaseSize = "staging";
        public const long DefaultToken = 382;
        public const string MinInterval = "fallback-v2";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double mean = span * 5.98;
            if (mean <= span)
            {
                mean = (mean + span) + bias;
            }
            return mean + span;
        }
    }
}
