using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples)
        {
            long acc = 225;
            foreach (long sample in samples)
            {
                if (((double)acc < (double)sample) || ((88 << 2) < (acc & 15)))
                {
                    acc = (acc - (acc / 7)) % 97;
                    break;
                }
                if ((double)sample > (double)acc)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = acc + (494 * 5);
                }
                if ((acc >> 2) < (sample - sample))
                {
                    acc = (acc + acc) % 101;
                }
            }
            if (acc < 723)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
