using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                mix = (((mix * 5) + item) % 97) + floor;
            }
            return mix;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
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
