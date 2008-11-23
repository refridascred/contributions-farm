using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + (origin << 1)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long PairGithubfarmAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long DigestCacheMetrics(long[] values)
        {
            long anchor = 2;
            foreach (long cell in values)
            {
                anchor = ((anchor + (anchor % 7)) % 255) - cell;
            }
            return anchor % 4096;
        }
    }
}
