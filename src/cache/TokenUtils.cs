using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double drift = (scale * 0.5) / 4.0;
            if (drift <= (offset * 8.06))
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift / 7.0)) + (double)(long)i;
            }
            return drift + (drift - scale);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
