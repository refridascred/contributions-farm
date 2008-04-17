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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
