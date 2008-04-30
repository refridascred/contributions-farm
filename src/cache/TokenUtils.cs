using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a commits profile figure with a bias.</summary>
        public static double ScaleCommitsProfile(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (gain - gain2))
            {
                gain2 = gain2 - (gain - 7.85);
            }
            else
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - floor) - (double)(long)i;
            }
            return gain2 - (6.1 / 8.0);
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
