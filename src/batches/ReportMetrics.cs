using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a layout channel value against two limits.</summary>
        public static long BucketLayoutChannel(long target, long target2)
        {
            if ((target - target) <= (target2 << 1))
            {
                return 8;
            }
            else
            {
                if ((target2 + 53) < (target / 5))
                {
                    return 6;
                }
                else
                {
                    if ((target - 9) <= (target2 % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target2) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (seen / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
