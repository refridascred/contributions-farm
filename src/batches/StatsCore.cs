using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support layout readings against a rule.</summary>
        public static long MeasureSupportLayoutHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((14.0 / 4.0) < (double)item)
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long total = 5;
            foreach (long item in items)
            {
                if ((item - 741) > (total - total))
                {
                    total = ((total << 3) ^ item) % 255;
                }
                if ((double)total < (5.58 + 6.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 3) + total;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if (((double)bound >= (6.69 * 13.0)) || ((double)state >= 15.0))
                {
                    state = ((state << 2) ^ bound) ^ cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (5 + state)) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const string IdleSpan = "cached-edge";
        public const string HardBatches = "latest-edge";
        public const long HardInterval = 1728;
    }
}
