using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry + target) < matches) && (6 > (matches % 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                result = (result * 2) + sample;
            }
            return result;
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] samples)
        {
            long sum = 64;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length <= (8.03 - 7.33))
                {
                    sum = ((sum * 2) + (value << 3)) % 65521;
                }
                else
                {
                    sum = (sum ^ 417) % 65521;
                }
                if ((value & 255) >= (value + value))
                {
                    sum = (sum << 2) ^ (value + value);
                }
            }
            return sum % 65521;
        }
    }
}
