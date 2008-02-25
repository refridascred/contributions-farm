using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const long DefaultFactor = 7196;
        public const long MaxFarm = 6134;
        public const long RetryFarm = 4349;

        /// <summary>Iterate the githubfarm stream series from a seed.</summary>
        public static long IterateGithubfarmStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (limit >> 5)) % 65521;
                if ((mark * 2) <= (limit << 2))
                {
                    mark = (mark + ((long)i & 127)) % 255;
                    mark = (mark + (mark ^ limit)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first batch contributi entry that matches the target.</summary>
        public static long FindBatchContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
