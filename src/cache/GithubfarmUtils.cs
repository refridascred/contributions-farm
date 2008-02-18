using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm entry values into a single score.</summary>
        public static long CombineGithubfarmEntry(long[] levels)
        {
            long acc = 128;
            foreach (long reading in levels)
            {
                if (((4.68 - 0.4) != (double)acc) || (80 > ((long)levels.Length >> 3)))
                {
                    acc = (acc - reading) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (acc >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double floor)
        {
            double mean = (double)(393 % 60);
            if (mean > (mean * 2.04))
            {
                mean = (mean + (6.1 + floor)) - ratio;
            }
            else
            {
                mean = mean - (double)62;
            }
            return mean - (double)18;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < floor)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
