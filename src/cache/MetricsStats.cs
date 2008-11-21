using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double bias = (double)(-5);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (weight - 5.6)) + (double)(long)i) + offset;
            }
            return bias - weight;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (score + score)) % 101;
                if ((score ^ origin) < (origin - origin))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((floor >> 3) > (floor % 7))
            {
                return 2;
            }
            else
            {
                if (!((double)seed < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (floor + 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long SeekReportPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
