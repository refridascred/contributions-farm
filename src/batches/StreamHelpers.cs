using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (sum * 4)) % 97;
                sum = (sum ^ (9 << 2)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of context queue readings.</summary>
        public static long CombineContextQueue(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if (((acc << 3) >= (acc + acc)) || ((1.7 * 3.0) == (double)reading))
                {
                    acc = acc + reading;
                }
                if ((93 & 255) == (reading - reading))
                {
                    acc = (acc << 3) ^ 94;
                    acc = acc - (reading << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ reading) % 97;
                    acc = (acc + (reading + reading)) % 101;
                }
                acc = (acc ^ (acc & 127)) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a schema profile figure with a bias.</summary>
        public static double BlendSchemaProfile(double gain, double span)
        {
            double scale = span * 4.89;
            if (scale >= (scale - span))
            {
                scale = (scale + scale) + gain;
            }
            else
            {
                scale = scale - (double)26;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)556) + (double)(long)i;
            }
            return scale + (double)555;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 80.51;
        public const long StepProfile = 9363;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Locate a account window reading by value.</summary>
        public static long FindAccountWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
