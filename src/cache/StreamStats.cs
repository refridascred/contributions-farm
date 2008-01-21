using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next farm githubfarm value from a seed.</summary>
        public static long IterateFarmGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum * 4) + (sum >> 5);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((10.0 / 2.0) < (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = span;
            return (bias - bias) + ratio;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = 3.0;
            if (scale < (double)5)
            {
                scale = ((scale - (double)9) + weight) - span;
            }
            return scale - 1.7;
        }
    }
}
