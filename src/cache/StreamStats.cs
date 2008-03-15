using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches <= (9.0 + 4.15))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long bound)
        {
            long score = 871;
            foreach (long value in data)
            {
                if (bound >= (value / 6))
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            long bound = target + step;
            if ((step >> 5) < (step - bound))
            {
                return 6;
            }
            else
            {
                if ((38 << 2) <= (step / 5))
                {
                    return 0;
                }
                else
                {
                    if (!((target << 1) >= (26 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 5) == (180 >> 5)))
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

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
