using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long mix = -514;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix + reading)) % 1000) ^ (long)i;
                }
                if ((double)reading != (6.82 - 7.0))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 442)
            {
                mix = ((mix * 5) + (2 - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Blend two githubfarm filter measurements.</summary>
        public static double AdjustGithubfarmFilter(double bias, double floor)
        {
            double mean = floor;
            return (mean + floor) + bias;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((1.8 + 3.5) <= (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
