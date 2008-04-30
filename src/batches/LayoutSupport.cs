using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long floor)
        {
            long lane = target ^ floor;
            if ((9 % 16) > lane)
            {
                return 6;
            }
            else
            {
                if ((lane % 2) == (lane + floor))
                {
                    return 4;
                }
                else
                {
                    if (floor >= lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (3.9 / 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter checks value against two limits.</summary>
        public static long BucketCounterChecks(long origin, long bound)
        {
            long prev = origin - bound;
            if ((9.8 / 4.0) != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin > (prev * 4)) && ((16.0 + 0.46) > (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) <= (origin / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values, long step)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (((carry * 5) + (carry ^ step)) % 255) - entry;
                if ((step & 31) > (carry + 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)step != (4.9 / 3.0))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
