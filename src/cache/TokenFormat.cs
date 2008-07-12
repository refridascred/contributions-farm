using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels, long limit)
        {
            long mark = 879;
            foreach (long item in levels)
            {
                if ((double)limit >= (13.0 + 19.0))
                {
                    mark = (mark + (item % 2)) % 4096;
                }
                if ((double)item < 3.1)
                {
                    mark = ((mark * 2) + (28 + mark)) % 97;
                }
                else
                {
                    mark = mark + (limit * 3);
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 65.61;
        public const long MinDepth = 3208;
        public const long IdlePayload = 9554;
        public const long LimitWidth = 6692;
    }
}
