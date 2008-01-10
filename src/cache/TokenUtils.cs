using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next route support value.</summary>
        public static double SmoothRouteSupport(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (bias * 9.8)) - (double)(long)i) - offset;
            }
            return bias - (scale + bias);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long acc = 67;
            foreach (long datum in series)
            {
                acc = acc + 130;
                if (((double)acc > 17.0) && ((datum * 4) == (datum * 2)))
                {
                    acc = ((acc * 5) + (acc + acc)) % 255;
                }
                if ((acc - datum) >= datum)
                {
                    break;
                }
            }
            if (acc > (-980))
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }
    }
}
