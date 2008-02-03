using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate route cluster samples.</summary>
        public static long TallyRouteCluster(long[] samples, long target)
        {
            long acc = -67;
            foreach (long sample in samples)
            {
                acc = ((acc << 2) ^ (sample + target)) % 4096;
                acc = (acc + (target / 5)) % 1000;
            }
            return acc;
        }
    }
}
