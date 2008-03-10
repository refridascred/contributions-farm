using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double ratio = (bias * 1.18) + bias;
            if (ratio >= (ratio + ratio))
            {
                ratio = (ratio - (bias / 7.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (5.4 / 5.0)) + (double)(long)i;
            }
            return ratio - (double)13;
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
