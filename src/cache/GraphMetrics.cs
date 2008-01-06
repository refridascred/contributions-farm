using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of profile format readings.</summary>
        public static long DigestProfileFormat(long[] samples, long limit)
        {
            long carry = 678;
            foreach (long cell in samples)
            {
                if ((carry ^ cell) > 925)
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry < (-9))
            {
                carry = (carry << 2) ^ ((-72) + limit);
            }
            return carry;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long bound)
        {
            long delta = target ^ bound;
            if ((double)delta >= (8.0 - 3.19))
            {
                return 5;
            }
            else
            {
                if (!((1.0 + 7.36) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta <= (3.94 * 7.0)) && ((573 + target) != (delta >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - delta) >= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
