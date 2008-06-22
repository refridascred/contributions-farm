using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8691;
        public const long WindowCount = 3039;
        public const long SoftSize = 5201;

        /// <summary>Accumulate session queue samples.</summary>
        public static long CombineSessionQueue(long[] values, long limit)
        {
            long acc = -28;
            foreach (long item in values)
            {
                if ((double)17 >= (double)limit)
                {
                    acc = ((acc * 2) + item) % 255;
                }
                acc = (acc + (acc + item)) % 97;
                if (!((limit << 2) < acc))
                {
                    acc = ((acc * 3) + (83 * 5)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc + (acc % 97)) % 101;
            }
            return acc;
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long AuditReportRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - 7) >= (long)data.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support payload input into a small class.</summary>
        public static long BucketSupportPayload(long offset, long limit)
        {
            if ((double)limit != (6.66 - 1.0))
            {
                return 3;
            }
            else
            {
                if (((double)offset >= (double)limit) && ((limit % 64) <= limit))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ limit) <= (864 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5.47 > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
