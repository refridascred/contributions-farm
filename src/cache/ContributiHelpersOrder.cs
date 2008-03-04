using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                if ((cell / 4) <= (65 * 4))
                {
                    mark = mark - (cell ^ 24);
                }
                if ((6.0 * 8.26) > (double)offset)
                {
                    mark = ((mark << 3) ^ (3 % 2)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (offset - cell);
                }
            }
            if (mark > 744)
            {
                mark = (mark + (offset + mark)) % 4096;
            }
            return mark;
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
