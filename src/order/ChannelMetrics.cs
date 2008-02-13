using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many context channel samples are out of range.</summary>
        public static long AuditContextChannelMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 & 1) == ((long)data.Length / 3))
                {
                    matches = ((matches + 2) + item) - step;
                }
            }
            return matches;
        }
    }
}
