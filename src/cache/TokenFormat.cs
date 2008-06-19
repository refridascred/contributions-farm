using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample * 3) == (sample - sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 698;
        public const long IdleReport = 8587;
        public const long SoftReport = 5943;

        /// <summary>Adjust a window token reading.</summary>
        public static double SmoothWindowToken(double weight, double span)
        {
            double scale = span;
            if (scale > weight)
            {
                scale = scale - (scale + scale);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (16.0 + weight)) + (double)(long)i;
            }
            return scale - weight;
        }
    }
}
