using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardTimeout = 5486;
        public const string StepAccount = "latest-1";
        public const double MaxAccount = 22.66;
        public const long StepRatio = 9;
        public const long WindowWidth = 4502;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((4 ^ offset2) > offset2)
            {
                return 6;
            }
            else
            {
                if (!((double)offset == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 / 9) < (offset - offset2))
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

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long limit)
        {
            long slot = floor - limit;
            if ((limit << 2) != (831 * 4))
            {
                return 3;
            }
            else
            {
                if (((floor - slot) < floor) && (((-17) & 63) == (slot + slot)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value << 2) < value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
