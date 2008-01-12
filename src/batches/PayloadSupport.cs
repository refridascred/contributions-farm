using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches > (1.0 * 6.7))
                {
                    matches = ((matches + 3) + cell) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
