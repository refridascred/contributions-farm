using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = -952;
            foreach (long cell in data)
            {
                if ((carry + carry) < (cell / 9))
                {
                    carry = (carry + (45 / 7)) % 255;
                }
                if ((cell + carry) > cell)
                {
                    break;
                }
            }
            if (carry < 993)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long seed)
        {
            if (!((4 + target) != (seed + target)))
            {
                return 2;
            }
            else
            {
                if ((seed - 7) >= (seed & 31))
                {
                    return 4;
                }
                else
                {
                    if (((target + seed) > (7 & 7)) && ((double)seed <= (11.0 + 1.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 795;
        public const long StepScore = 6740;
        public const long WindowScore = 8562;
        public const long SoftInterval = 9297;
    }
}
