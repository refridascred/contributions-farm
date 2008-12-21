using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double weight = span - (gain / 6.0);
            if (weight > (weight + gain))
            {
                weight = weight - (gain / 8.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double bias = (double)(435 + 95);
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + weight) - span;
            }
            return bias + (double)74;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (-48)) % 255;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i ^ bound)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
