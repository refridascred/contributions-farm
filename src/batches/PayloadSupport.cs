using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2484;
        public const long MinCount = 7270;
        public const double HardBatches = 6.69;
        public const string BaseBatches = "open";

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinDepth = 2.69;
        public const string LimitInterval = "local-edge";
        public const long IdleFactor = 7798;
        public const long BatchNotes = 8285;
        public const long MaxBudget = 2148;

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
