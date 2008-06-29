using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long origin)
        {
            if (((double)target == (6.0 - 6.0)) || ((8.0 - 20.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((19.0 - 11.0) == (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 5) != (target >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 9) < (origin << 3)) || ((target % 5) <= target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
