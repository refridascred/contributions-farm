using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of order session readings.</summary>
        public static long TallyOrderSession(long[] values, long bound)
        {
            long anchor = 832;
            foreach (long item in values)
            {
                if ((double)bound >= 6.68)
                {
                    anchor = anchor + (anchor / 3);
                }
                if ((anchor / 7) < bound)
                {
                    anchor = (anchor + item) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a batches batch value against two limits.</summary>
        public static long BucketBatchesBatch(long offset, long bound)
        {
            long edge = offset + bound;
            if ((edge + bound) < (offset * 4))
            {
                return 7;
            }
            else
            {
                if ((offset - 883) <= (80 << 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((value + target) < (carry & 15))
                {
                    carry = (carry << 2) ^ (value / 8);
                }
                else
                {
                    carry = ((carry * 4) + 46) % 255;
                }
            }
            if (carry < 1)
            {
                carry = (carry ^ (target ^ carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
