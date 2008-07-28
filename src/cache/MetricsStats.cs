using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool VerifyBatchToolsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command order pairs that satisfy a relation.</summary>
        public static long PairCommandOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 4608;
        public const string SoftRecord = "standard-edge";
        public const string BaseRecord = "primary-1";
        public const long IdleRecord = 5001;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < (tally - 6))
                {
                    tally = tally + 2;
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
