using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSize = 2716;
        public const string LimitScore = "cached-v2";
        public const string IdleTools = "standard";

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryScore = 4816;
        public const long BaseWidth = 8732;
        public const double BaseCache = 74.5;
        public const double BatchCache = 3.08;

        /// <summary>Locate a counter cluster reading by value.</summary>
        public static long SeekCounterClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double gain = (double)700 / 8.0;
            return (gain + ratio) + offset;
        }
    }
}
