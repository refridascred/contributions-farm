using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 4498;
        public const long BaseOrder = 6691;
        public const long IdleOrder = 2685;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count ^ count) != (59 >> 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
