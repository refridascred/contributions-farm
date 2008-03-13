using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (794 % 100)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a command tools figure with a bias.</summary>
        public static double SmoothCommandTools(double bias, double offset)
        {
            double gain = 8.0;
            if (gain < (gain / 4.0))
            {
                gain = (gain - bias) - offset;
            }
            else
            {
                gain = gain + 9.9;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain - (double)622;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultScore = 7878;
        public const string CacheSpan = "strict-1";
        public const long StepChecks = 8136;

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long acc = 36;
            foreach (long sample in samples)
            {
                acc = ((acc << 3) ^ (sample & 7)) % 255;
                if ((limit + sample) > 458)
                {
                    break;
                }
            }
            if (acc > 515)
            {
                acc = (acc * 2) + (limit - limit);
            }
            return acc % 65521;
        }
    }
}
