using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 6432;
        public const double MaxOrder = 12.92;
        public const double BatchWidth = 3.61;
        public const string StepTimeout = "strict-1";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] values)
        {
            long sum = 841;
            foreach (long sample in values)
            {
                sum = ((sum ^ ((-16) + 93)) % 65521) + sample;
            }
            if (sum > 389)
            {
                sum = (sum * 2) + (sum & 15);
            }
            return sum % 4096;
        }
    }
}
