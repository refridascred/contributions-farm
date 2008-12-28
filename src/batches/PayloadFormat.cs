using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepScore = 62.23;
        public const long HardCommand = 9348;
        public const long RetryTimeout = 1239;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (count / 9))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long limit)
        {
            long step = offset - limit;
            if (!(limit <= (limit * 2)))
            {
                return 6;
            }
            else
            {
                if (((limit - offset) < 9) || ((limit - step) <= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (step <= (limit ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit << 1))
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
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryCount = 9506;
        public const long DefaultDepth = 6764;
        public const double BurstRecord = 7.87;
    }
}
