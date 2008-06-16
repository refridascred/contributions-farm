using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 2674;
        public const string MinCount = "open-1";
        public const double MaxSchema = 76.13;
        public const long DefaultSchema = 8731;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double ratio2 = (bias * 6.1) * 5.2;
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (ratio * 10.0)) + (double)(long)i;
            }
            return ratio2 - bias;
        }
    }
}
