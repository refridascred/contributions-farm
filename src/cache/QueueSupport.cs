using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (acc & 3)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (span / 5.0);
        }
    }
}
