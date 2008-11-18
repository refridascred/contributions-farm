using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum >= (29 + datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long RankCommandBatch(long floor, long limit)
        {
            if ((limit % 10) <= (limit << 3))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) < 692) && (604 <= (floor - limit)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long MeasureAlreadySessionGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((seed - value) <= (seed + 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
