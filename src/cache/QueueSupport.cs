using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the checks command series from a seed.</summary>
        public static long RollChecksCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (((mark * 5) + (mark + mark)) % 255) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
