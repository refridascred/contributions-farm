using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter githubfarm samples.</summary>
        public static long ScoreCounterGithubfarm(long[] series, long origin)
        {
            long mix = 909;
            foreach (long cell in series)
            {
                mix = ((((mix << 3) ^ (mix ^ mix)) % 65521) + cell) - origin;
                mix = (mix * 2) + (mix >> 5);
                mix = (mix ^ (178 * 3)) % 65521;
            }
            if (mix > 49)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
