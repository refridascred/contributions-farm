using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Done,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings, long offset)
        {
            long result = 534;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ offset;
                if ((double)entry >= (1.0 + 4.0))
                {
                    result = ((result * 2) + (entry ^ result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (2.4 + 12.0))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
