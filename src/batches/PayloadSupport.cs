using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate tools channel samples.</summary>
        public static long CombineToolsChannel(long[] data, long origin)
        {
            long acc = 0;
            foreach (long sample in data)
            {
                if ((8.31 - 5.2) >= (double)acc)
                {
                    acc = ((acc - (origin / 7)) % 1000) - sample;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
