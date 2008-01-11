using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (offset - drift))
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + 16.0;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 365;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor * 5) + (anchor * 3)) % 97) + (long)i;
                }
                anchor = (anchor * 3) + (sample >> 1);
                anchor = ((anchor << 2) ^ 81) % 255;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
