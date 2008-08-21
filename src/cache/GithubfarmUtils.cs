using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double ProjectContextEntry(double gain, double floor)
        {
            double mean = gain;
            if (mean < floor)
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Iterate the token cache series from a seed.</summary>
        public static long SeriesTokenCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)state != (double)origin)
                {
                    state = state - (origin % 10);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a tools stream sample.</summary>
        public static long SeekToolsStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
