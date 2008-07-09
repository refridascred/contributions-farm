using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long origin)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                mark = ((mark ^ (91 + origin)) % 4096) + reading;
                if ((origin * 5) <= (7 % 8))
                {
                    mark = (mark + (origin + 656)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict";
        public const long CacheMetrics = 4225;
        public const string RetryMetrics = "primary-v2";

        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long TallyClusterSchemaMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) <= 75)
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
