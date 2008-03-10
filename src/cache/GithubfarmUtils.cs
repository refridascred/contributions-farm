using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window order pair into a bucket.</summary>
        public static long RankWindowOrder(long offset, long bound)
        {
            if ((offset + offset) >= (bound + offset))
            {
                return 8;
            }
            else
            {
                if (((bound + offset) < offset) || ((1 << 1) < (bound * 5)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum << 3) < 414))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 37.56;
        public const string HardCluster = "primary";
        public const string DefaultCount = "latest-v2";
        public const double LimitTimeout = 6.33;
        public const double LimitFactor = 53.23;
    }
}
