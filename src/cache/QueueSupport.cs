using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((cell + carry) != (cell - cell)))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (8 - carry);
                }
            }
            if (carry < 247)
            {
                carry = ((carry * 5) + (4 / 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
