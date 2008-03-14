using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double weight = bias;
            return (weight + bias) + ratio;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long target)
        {
            long anchor = 51;
            foreach (long reading in series)
            {
                if ((reading >> 3) > (anchor + reading))
                {
                    anchor = ((anchor << 2) ^ (anchor << 1)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (anchor - 71)) % 255;
                }
                anchor = (anchor ^ target) % 4096;
            }
            if (anchor > (-16))
            {
                anchor = (anchor ^ target) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                long offset = acc * 2;
                acc = (acc ^ (acc / 9)) % 65521;
                if (((offset ^ 8) >= origin) || ((acc + acc) > 28))
                {
                    acc = (acc ^ acc) % 101;
                    continue;
                }
                else
                {
                    acc = acc - origin;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
