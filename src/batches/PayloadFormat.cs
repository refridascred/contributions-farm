using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 35.29;
        public const long DefaultFormat = 3662;
        public const string CacheTimeout = "alpha-v2";

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long limit)
        {
            long offset = step ^ limit;
            if (((double)limit > (double)511) || ((step + offset) > (offset << 3)))
            {
                return 3;
            }
            else
            {
                if ((step - 260) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((39 * 4) != (offset % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine stream counter values into a single score.</summary>
        public static long WeighStreamCounter(long[] samples, long origin)
        {
            long score = 314;
            foreach (long sample in samples)
            {
                score = score ^ (score * 5);
                if (!((9 % 10) < (origin / 5)))
                {
                    score = (score ^ origin) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample % 7);
                }
            }
            return score;
        }
    }
}
