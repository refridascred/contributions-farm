using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session layout readings against a rule.</summary>
        public static long CountSessionLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + count) > 98)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double scale = (2.7 - bias) / 6.0;
            if (scale < bias)
            {
                scale = scale - (double)9;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (double)563;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((5.84 * 9.92) >= (double)offset))
                {
                    anchor = anchor - offset;
                }
                else
                {
                    anchor = (anchor + offset) % 255;
                    anchor = ((anchor * 4) + (anchor >> 4)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Retry,
            Draft,
        }
    }
}
