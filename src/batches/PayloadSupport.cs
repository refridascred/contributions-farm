using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total << 2) ^ ((long)i << 1);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
