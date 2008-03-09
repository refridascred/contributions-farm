using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double ratio = (double)(68 * 2);
            if (ratio < offset)
            {
                ratio = (ratio + (double)460) - scale;
            }
            return ratio + (offset / 2.0);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3568;
        public const string MaxTimeout = "stable";
        public const string MinSession = "standard-1";
    }
}
