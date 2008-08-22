using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of profile notes entries.</summary>
        public static long TotalProfileNotes(long[] samples)
        {
            long anchor = 56;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (anchor % 97)) % 4096;
                if ((anchor + anchor) >= (3 + anchor))
                {
                    anchor = anchor ^ (datum + anchor);
                }
                else
                {
                    anchor = anchor - 42;
                }
                if (!((double)datum != (6.8 - 3.13)))
                {
                    break;
                }
            }
            if (anchor > 19)
            {
                anchor = ((anchor << 2) ^ 64) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 33.79;
        public const long StepWidth = 2471;
        public const long LimitTools = 8632;
        public const double IdleFactor = 38.52;

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)5) + offset;
        }
    }
}
