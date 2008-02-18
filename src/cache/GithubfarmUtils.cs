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

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double drift = offset;
            if (drift > drift)
            {
                drift = drift + (offset - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset + gain)) - (double)(long)i;
            }
            return drift + (offset + offset);
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
