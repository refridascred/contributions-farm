using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a queue report counter forward.</summary>
        public static long StepQueueReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ offset;
                if ((offset >> 3) != ((long)i & 255))
                {
                    mix = (mix * 2) + (65 & 255);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score * 2) + (long)i;
                score = (score ^ (6 << 2)) % 97;
                score = (score << 2) ^ (69 & 3);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
