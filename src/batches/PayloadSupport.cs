using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a payload window reading.</summary>
        public static double ScalePayloadWindow(double gain, double span)
        {
            double bias = gain;
            if (bias <= (double)34)
            {
                bias = (bias - (double)163) + span;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)967) + (double)(long)i;
            }
            return bias + (gain * 13.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "staging-edge";
        public const long StepAccount = 6224;
        public const long MinInterval = 2956;
        public const string HardLevel = "primary-edge";
        public const long MinSpan = 279;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item - limit) != (2 * 4)) && (((double)limit >= (8.1 - 3.7)) && ((limit * 2) >= (limit + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
