using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values, long origin)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                if ((sample ^ origin) != (mix % 10))
                {
                    mix = ((mix << 3) ^ (origin + origin)) % 101;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 4096;
                }
                if ((mix % 100) < (22 & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
