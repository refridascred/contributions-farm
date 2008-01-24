using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series)
        {
            long result = 849;
            foreach (long value in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result - (result + (long)i)) % 101) - value;
                }
                result = result ^ (49 - result);
            }
            return result % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 9925;
        public const long BatchCluster = 4409;
        public const long BaseBudget = 6880;

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = mark - (seed - cell);
                if (((cell - mark) <= cell) && (9.5 > (9.71 / 5.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long bound = offset - target;
            if (target <= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (((10.0 + 3.9) < (double)bound) || ((45 - bound) <= (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
