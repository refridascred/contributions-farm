using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if (937 < (offset + mix))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)i) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 5741;
        public const long SoftPayload = 3121;
        public const long BasePayload = 7237;
    }
}
