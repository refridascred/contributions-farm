using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            if (0 > (bound + limit))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (8 < (bound * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 - 14.0) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order commits samples.</summary>
        public static long CombineOrderCommits(long[] data, long origin)
        {
            long anchor = 16;
            foreach (long item in data)
            {
                anchor = (((anchor ^ (anchor / 6)) % 97) - item) + origin;
            }
            return anchor;
        }

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long MeasureProfileCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)sample >= (6.2 - 5.7)) || ((sample ^ seen) >= (262 + 0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long CompareTokenFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
