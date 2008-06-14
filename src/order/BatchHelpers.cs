using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a counter layout counter forward.</summary>
        public static long RollCounterLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
