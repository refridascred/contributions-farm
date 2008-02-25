using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double ratio = (bias + bias) * 5.8;
            return (ratio - (bias + ratio)) + span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches >= offset)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= datum)
                {
                    sum = sum - (seed << 3);
                }
                else
                {
                    sum = (sum ^ (seed ^ sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double scale = offset - ratio;
            if (scale > (scale + ratio))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + 2.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (2.9 / 7.0)) - (double)(long)i;
            }
            return scale - (double)4;
        }
    }
}
