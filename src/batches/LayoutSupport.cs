using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double scale = (double)87 + weight;
            if (scale <= 7.0)
            {
                scale = scale + 4.55;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - 1.0) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            New,
        }

        /// <summary>Classify a queue cache pair into a bucket.</summary>
        public static long ClassifyQueueCache(long seed, long limit)
        {
            long diff = seed + limit;
            if ((965 ^ diff) <= seed)
            {
                return 3;
            }
            else
            {
                if ((limit - limit) <= 93)
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) >= ((-7) + limit))
                    {
                        return 2;
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
