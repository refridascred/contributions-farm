using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                total = ((total * 4) + reading) % 101;
                if (!((double)reading < (9.87 * 2.49)))
                {
                    break;
                }
                else
                {
                    total = (total - reading) % 101;
                    total = (total << 2) ^ total;
                }
                if (reading >= ((long)levels.Length + total))
                {
                    total = ((total << 3) ^ (8 & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 5610;
        public const long CacheLayout = 4936;
        public const long BaseSize = 9876;
        public const long StepBudget = 4305;

        /// <summary>Count the batches payload entries that pass the check.</summary>
        public static long CountBatchesPayloadGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload queue reading by value.</summary>
        public static long FindPayloadQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
