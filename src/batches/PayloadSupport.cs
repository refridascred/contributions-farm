using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((limit * 4) <= (tally & 127)) || ((limit - 736) >= (tally << 2))) && (((tally ^ 65) >= (228 / 6)) || ((limit + 77) >= reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long seed)
        {
            long delta = target + seed;
            if ((seed - target) == (3 + delta))
            {
                return 6;
            }
            else
            {
                if (!((794 + 3) < (delta - delta)))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target <= (4.41 + 14.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultInterval = "alpha-1";
        public const double LimitBatches = 80.62;
        public const long DefaultCount = 6234;
    }
}
