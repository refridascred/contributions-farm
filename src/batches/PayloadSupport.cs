using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long edge = floor + seed;
            if ((floor & 127) > (seed ^ 306))
            {
                return 3;
            }
            else
            {
                if ((floor - floor) > (seed - edge))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.0 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed % 60) <= edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
