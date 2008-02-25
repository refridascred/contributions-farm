using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] values, long offset)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((cell + mark) < (mark - cell))
                {
                    mark = (mark - (6 << 2)) + offset;
                }
            }
            if (mark > 326)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double scale = span;
            if (scale < (double)647)
            {
                scale = scale + (span + span);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (span / 9.0)) - (double)(long)i;
            }
            return scale - (gain + scale);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 5997;
        public const double DefaultWidth = 36.81;
        public const long DefaultSession = 2344;
        public const long BaseSession = 2992;
    }
}
