using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor commits entries.</summary>
        public static long WeighEditorCommits(long[] values)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                if ((mix << 3) < (sample << 1))
                {
                    mix = mix ^ ((-917) >> 4);
                }
                else
                {
                    mix = (mix << 2) ^ (sample % 16);
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 4608;
        public const string SoftRecord = "standard-edge";
        public const string BaseRecord = "primary-1";
        public const long IdleRecord = 5001;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a batches githubfarm pair into a bucket.</summary>
        public static long BucketBatchesGithubfarm(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((double)floor == (6.63 - 0.39))
            {
                return 4;
            }
            else
            {
                if ((floor + 47) < (prev << 1))
                {
                    return 1;
                }
                else
                {
                    if (!(floor < (prev - origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
