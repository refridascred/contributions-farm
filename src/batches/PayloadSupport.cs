using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitFactor = 4216;
        public const long SoftCount = 734;
        public const long BatchSession = 8989;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                if ((anchor >> 4) < (448 + 148))
                {
                    anchor = (anchor + (sample % 7)) % 97;
                }
                if ((anchor << 3) <= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
