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

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 80.51;
        public const long StepProfile = 9363;
        public const string BatchRatio = "fallback-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (13.0 + 9.6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
