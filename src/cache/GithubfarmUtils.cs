using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading + count)) || (63 < ((long)items.Length >> 5)))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long total = 37;
            foreach (long entry in readings)
            {
                total = (total ^ (entry - entry)) + step;
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((double)cell > (1.5 + 2.8))
                {
                    acc = (acc + (acc + 488)) % 1000;
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 3)) % 101;
                }
                acc = ((acc << 3) ^ (acc >> 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (ratio - ratio))
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (8.5 / 9.0)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
