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

        /// <summary>Validate order window readings against a bound.</summary>
        public static bool ValidateOrderWindowRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
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
