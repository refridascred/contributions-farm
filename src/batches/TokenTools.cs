using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double load = scale;
            return load + (scale + span);
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double SmoothSupportBuffer(double rate, double span)
        {
            double bias = rate;
            if (bias < (bias * 9.2))
            {
                bias = (bias + (bias - bias)) + span;
            }
            else
            {
                bias = bias - (7.0 * 1.1);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (rate + rate)) + (double)(long)i;
            }
            return bias - (double)(-23);
        }

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long AuditClusterBatchMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 1) <= 241)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
