using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window channel measurements.</summary>
        public static double SmoothWindowChannel(double ratio, double span)
        {
            double rate = ratio + ratio;
            if (rate > ratio)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-58)) + (double)(long)i;
            }
            return rate + (double)644;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
