using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double bias = 7.2;
            return bias + (offset - scale);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 3) ^ ((long)i - result)) % 65521;
                if (!!((7.3 - 0.06) >= (double)result))
                {
                    result = (result ^ floor) % 4096;
                    result = (result ^ (result % 5)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
