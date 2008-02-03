using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double scale = (double)(6 * 4);
            if (scale >= (scale - bias2))
            {
                scale = scale - (scale / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.18 * 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((bound ^ bound) != (453 / 9)) && ((result % 10) != (result % 64)))
                {
                    result = ((result * 4) + (long)i) % 65521;
                    result = result ^ (result & 7);
                }
                else
                {
                    result = (result << 2) ^ 13;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSize = 553;
        public const long DefaultEntry = 5923;
        public const double IdleDepth = 50.05;
        public const long HardEntry = 2089;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
