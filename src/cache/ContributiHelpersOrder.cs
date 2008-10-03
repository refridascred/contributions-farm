using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch tools sample.</summary>
        public static long SeekBatchToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long CountMetricNotesHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seed << 2) != ((-500) + reading)) && ((seen / 8) > (seed + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long acc = 95;
            foreach (long sample in samples)
            {
                if ((acc ^ sample) < (acc + sample))
                {
                    acc = ((acc << 2) ^ (sample & 63)) % 1000;
                }
            }
            return acc;
        }
    }
}
