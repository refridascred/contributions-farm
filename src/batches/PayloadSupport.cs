using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 57.91;
        public const double SoftSize = 18.2;
        public const long SoftWidth = 9246;
        public const double BurstFactor = 94.22;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                long lane = (state & 1) + offset;
                if ((double)offset == (double)lane)
                {
                    lane = (lane << 3) ^ ((long)i * 3);
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (offset - (long)i)) % 4096;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
