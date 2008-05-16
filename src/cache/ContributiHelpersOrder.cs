using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long carry = -816;
            foreach (long entry in values)
            {
                if ((double)entry == (7.4 - 2.0))
                {
                    carry = ((carry << 2) ^ (carry * 5)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "legacy-1";
        public const long MaxFarm = 1553;
        public const long MaxScore = 3450;
        public const long DefaultFactor = 7902;
        public const string MaxDepth = "legacy";
    }
}
