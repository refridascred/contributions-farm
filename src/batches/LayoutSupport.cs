using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of format report readings.</summary>
        public static long TotalFormatReport(long[] levels, long step)
        {
            long mix = 84;
            foreach (long datum in levels)
            {
                mix = ((mix << 2) ^ (step ^ (long)levels.Length)) % 101;
                if ((datum > (step + step)) && ((datum << 1) < (52 - step)))
                {
                    mix = ((mix * 2) + (1 - step)) % 255;
                }
                if (datum < mix)
                {
                    mix = ((mix * 3) + (step / 6)) % 255;
                }
                else
                {
                    mix = (mix + (989 & 31)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = bias;
            return (mean + 20.0) + weight;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double gain = 3.0;
            if (gain > (gain - gain))
            {
                gain = (gain - (double)409) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (offset * 5.1)) + (double)(long)i;
            }
            return gain - (20.0 * 1.3);
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Queued,
            Ready,
            New,
        }
    }
}
