using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long acc = 955;
            foreach (long reading in samples)
            {
                if ((acc * 2) <= 6)
                {
                    acc = ((acc - (acc & 31)) % 65521) - origin;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - reading)) % 97;
                }
            }
            return acc;
        }
    }
}
