using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (mean + floor))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long mark = 88;
            foreach (long sample in samples)
            {
                if ((2.0 - 8.6) >= (double)mark)
                {
                    mark = (((mark ^ (779 >> 4)) % 1000) - sample) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                bool stale = (double)origin > (0.4 - 11.0);
                if (stale)
                {
                    break;
                }
                stale = !stale;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
