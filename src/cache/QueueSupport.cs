using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the command order series from a seed.</summary>
        public static long SeriesCommandOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - (60 + bound);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
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
