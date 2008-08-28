using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 6266;
        public const long RetryCount = 5358;
        public const long BaseContext = 588;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 63) == (count + 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((4.0 * 13.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - bound) != (9 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((9.26 - 9.89) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 3) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
