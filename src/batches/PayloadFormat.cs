using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry >= ((long)series.Length / 3))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next order record value.</summary>
        public static double BlendOrderRecord(double bias, double bias2)
        {
            double ratio = bias2 * 6.91;
            if (ratio > (double)(-59))
            {
                ratio = (ratio - (ratio - ratio)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio - 8.7;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4456;
        public const double BaseEditor = 96.54;
        public const string RetryEditor = "staging-edge";
        public const double RetryTimeout = 73.62;
    }
}
