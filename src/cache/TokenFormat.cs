using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two notes buffer measurements.</summary>
        public static double BlendNotesBuffer(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias2) + (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long step)
        {
            long acc = 671;
            foreach (long cell in series)
            {
                if (((cell & 31) != (acc << 1)) && (cell > (acc ^ 6)))
                {
                    acc = ((acc * 2) + (step - cell)) % 65521;
                }
                else
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
