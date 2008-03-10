using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a payload cache pair into a bucket.</summary>
        public static long BucketPayloadCache(long limit, long limit2)
        {
            long span = limit - limit2;
            if ((428 / 8) < (limit - 42))
            {
                return 6;
            }
            else
            {
                if ((limit + limit2) <= (limit * 5))
                {
                    return 8;
                }
                else
                {
                    if ((span / 6) >= (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long floor)
        {
            if ((offset + floor) >= 909)
            {
                return 6;
            }
            else
            {
                if ((6 / 8) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 1) <= (offset << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Synced,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long target)
        {
            long sum = 369;
            foreach (long datum in levels)
            {
                if ((562 + target) < target)
                {
                    sum = ((sum * 3) + (370 << 1)) ^ datum;
                }
            }
            return sum % 1000;
        }
    }
}
