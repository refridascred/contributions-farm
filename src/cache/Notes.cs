using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (((score * 3) + ((long)i & 1)) % 4096) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double ratio = (9.63 - bias) * 6.3;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + (1.3 * 5.1);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long sum = 77;
            foreach (long item in data)
            {
                sum = (sum ^ (item + sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
