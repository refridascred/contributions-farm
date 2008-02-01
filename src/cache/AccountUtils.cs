using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema support pair into a bucket.</summary>
        public static long GradeSchemaSupport(long step, long offset)
        {
            if ((step << 3) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((double)offset > (6.0 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (0 <= (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate command metrics samples.</summary>
        public static long CombineCommandMetrics(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if ((81 <= acc) && ((double)acc >= (9.13 + 0.2)))
                {
                    acc = (((acc << 3) ^ (acc << 1)) % 97) - sample;
                }
                else
                {
                    acc = (acc + (acc * 2)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                if ((-325) <= (datum + datum))
                {
                    total = (total ^ (datum * 3)) % 97;
                }
            }
            return total;
        }
    }
}
