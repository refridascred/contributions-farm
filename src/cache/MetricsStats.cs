using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long MeasureSchemaGithubfarmGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((target * 2) > entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
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
