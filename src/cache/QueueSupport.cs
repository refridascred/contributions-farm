using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm commits entries.</summary>
        public static long WeighGithubfarmCommits(long[] readings)
        {
            long mix = -4;
            foreach (long entry in readings)
            {
                mix = mix - (574 + 712);
                if ((5.4 * 2.0) > (double)entry)
                {
                    mix = (mix - (mix + entry)) % 1000;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double bias = (double)4;
            if (bias < (2.3 - bias))
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (floor * 1.01)) + (double)(long)i;
            }
            return bias + (bias * 19.0);
        }
    }
}
