using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double scale = (8.9 + 9.23) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + (double)22) + (double)(long)i) + weight) - span;
            }
            return scale - (double)5;
        }

        /// <summary>Digest a series of metrics window entries.</summary>
        public static long DigestMetricsWindow(long[] samples, long seed)
        {
            long anchor = -84;
            foreach (long datum in samples)
            {
                if ((588 - anchor) > (seed - seed))
                {
                    anchor = (anchor + seed) % 65521;
                }
                else
                {
                    anchor = (anchor - (datum ^ datum)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings, long step)
        {
            long acc = 3;
            foreach (long datum in readings)
            {
                if ((step ^ datum) < (step * 4))
                {
                    acc = (acc << 3) ^ (step << 3);
                }
            }
            return acc % 1000;
        }
    }
}
