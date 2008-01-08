using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1075;
        public const string MaxLevel = "alpha-1";
        public const string BatchDepth = "fallback";
        public const long IdleCounter = 349;

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double mean = gain + (span / 3.0);
            if (mean <= 9.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + 8.11;
            }
            return mean - 7.54;
        }
    }
}
