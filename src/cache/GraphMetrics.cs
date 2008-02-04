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

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool ValidateContextGraphLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheCount = 87.05;
        public const long RetrySpan = 5690;
        public const long BaseLevel = 824;
    }
}
