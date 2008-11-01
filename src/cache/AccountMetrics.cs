using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((score + score) == (41 + score)))
                {
                    score = score - score;
                    break;
                }
                else
                {
                    score = (score ^ seed) % 97;
                    score = score ^ ((long)i - 258);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            if (limit < (limit2 ^ 282))
            {
                return 5;
            }
            else
            {
                if (((double)limit2 >= 8.0) || ((limit2 << 3) <= limit))
                {
                    return 6;
                }
                else
                {
                    if ((limit2 << 2) > limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long DigestProfileCluster(long[] values, long floor)
        {
            long mark = 537;
            foreach (long datum in values)
            {
                if (datum <= (datum << 3))
                {
                    mark = (((mark * 2) + mark) % 1000) - floor;
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long FindQueueBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
