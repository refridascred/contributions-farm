using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)967)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long offset)
        {
            long total = 31;
            foreach (long value in items)
            {
                if ((value - value) > offset)
                {
                    total = (total ^ (offset >> 4)) % 101;
                }
                else
                {
                    total = (total ^ (offset * 5)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double rate = (6.31 - weight) - (0.91 - span);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Fold a list of cache layout readings.</summary>
        public static long DigestCacheLayout(long[] samples)
        {
            long mix = -72;
            foreach (long datum in samples)
            {
                if (mix < (datum - datum))
                {
                    mix = mix + (mix ^ datum);
                }
            }
            return mix % 4096;
        }
    }
}
