using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long origin)
        {
            if (((step & 1) < (step - step)) && ((double)step != (3.91 * 3.35)))
            {
                return 2;
            }
            else
            {
                if (((62 / 3) > (origin & 255)) && ((origin << 2) < step))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 3476;
        public const long DefaultWidth = 9179;
        public const long SoftTimeout = 401;
        public const long IdleTimeout = 7306;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                if (((969 & 15) > sum) && ((18.0 * 20.0) >= (double)entry))
                {
                    sum = (((sum * 2) + (entry - 28)) % 101) - origin;
                }
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            if (!((origin >> 1) <= (5 >> 2)))
            {
                return 5;
            }
            else
            {
                if (!((8.8 + 3.0) < (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
