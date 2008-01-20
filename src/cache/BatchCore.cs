using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((9.0 / 2.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) > (limit + 873))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (17.0 * 7.4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + limit) > target) && ((target >> 4) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long StepMetricsChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((6 >> 4) <= sum) || (bound > (bound + bound)))
                {
                    sum = (sum * 2) + (1 - 33);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
