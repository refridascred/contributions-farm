using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double gain = (double)(78 % 16);
            if (gain >= floor)
            {
                gain = (gain + (floor - floor)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (0.85 / 2.0)) + (double)(long)i;
            }
            return gain + (gain * 16.0);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
