using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((value / 6) > value)
                {
                    mix = (mix + (mix << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((78 & 127) >= (cell - 85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
