using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long acc = -992;
            foreach (long sample in levels)
            {
                acc = acc + (sample + seed);
            }
            if (acc > 10)
            {
                acc = (acc ^ (42 << 2)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
