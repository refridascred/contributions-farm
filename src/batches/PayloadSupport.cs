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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - 63) == (681 & 31))
                {
                    seen = ((seen + 3) - datum) - bound;
                }
            }
            return seen;
        }
    }
}
