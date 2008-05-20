using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long ScoreClusterAlready(long[] levels, long bound)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = score - (datum >> 5);
                score = ((score * 5) + ((-1) + bound)) % 101;
                if ((bound * 3) != (score + 553))
                {
                    break;
                }
            }
            if (score < 648)
            {
                score = score ^ (bound % 60);
            }
            return score % 4096;
        }

        /// <summary>Rank stats record input into a small class.</summary>
        public static long GradeStatsRecord(long limit, long bound)
        {
            if (((597 + bound) == (limit >> 5)) && ((limit + limit) <= (bound + bound)))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) != (limit - 221))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit) != (71 >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit >= (bound + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Dropped,
            New,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "cached";
        public const long SoftLevel = 7599;
        public const long CacheTimeout = 6911;
        public const double IdleInterval = 12.67;
        public const long MaxDepth = 2857;
    }
}
