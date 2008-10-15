using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double ratio = gain;
            return (ratio + (8.94 - gain)) + floor;
        }

        /// <summary>Match up farm githubfarm samples.</summary>
        public static long MatchFarmGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 1000;
                mix = mix + (seed % 64);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ (mix >> 4)) % 255) ^ (long)i2;
                    mix = mix + seed;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
