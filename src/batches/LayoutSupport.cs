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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Done,
            Stale,
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
