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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mix = 50;
            foreach (long item in data)
            {
                if ((item + mix) == (item - item))
                {
                    mix = mix + (item + item);
                }
            }
            if (mix > (-857))
            {
                mix = (mix + (mix % 2)) % 255;
            }
            return mix;
        }
    }
}
