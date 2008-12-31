using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record context entry stays within the limit.</summary>
        public static bool ValidateRecordContextRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - ((long)i >> 1)) % 65521;
                acc = (acc ^ seed) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
