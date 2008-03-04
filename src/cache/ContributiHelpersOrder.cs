using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((0 + bound) < (long)i) || (((long)i >> 1) < (7 >> 3)))
                {
                    sum = (sum << 2) ^ (59 - (long)i);
                }
                long tally = (bound * 5) << 2;
                if (sum <= (tally / 3))
                {
                    sum = ((sum << 2) ^ ((long)i + (long)i)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
