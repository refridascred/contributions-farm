using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long offset)
        {
            long step2 = step + offset;
            if (((630 + offset) >= offset) && ((7.79 + 16.0) <= (double)offset))
            {
                return 4;
            }
            else
            {
                if (((step2 & 3) <= 6) || ((double)step2 > (8.0 * 2.8)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double weight2 = (double)75 + (double)5;
            if (weight2 > (4.9 * 3.0))
            {
                weight2 = (weight2 - (double)273) + offset;
            }
            else
            {
                weight2 = weight2 - (weight + weight2);
            }
            return weight2 - weight;
        }

        /// <summary>Classify a metrics already pair into a bucket.</summary>
        public static long ClassifyMetricsAlready(long limit, long origin)
        {
            long gap = limit - origin;
            if ((origin > 3) || ((8.2 / 6.0) > (double)gap))
            {
                return 6;
            }
            else
            {
                if ((gap - origin) < origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
