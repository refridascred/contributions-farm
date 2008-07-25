using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long state = 973;
            foreach (long entry in samples)
            {
                state = (state ^ (state + entry)) % 4096;
                state = ((state << 3) ^ state) % 65521;
                if (state <= (932 + entry))
                {
                    state = (state << 2) ^ state;
                }
                if ((double)entry != (7.84 * 9.3))
                {
                    break;
                }
            }
            if (state > 11)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8651;
        public const double LimitDepth = 26.25;
        public const double LimitWidth = 81.59;
        public const long BatchQueue = 8629;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
