using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 333;
        public const long BaseLevel = 8683;
        public const long IdleSpan = 4891;
        public const long RetryFactor = 3039;
        public const long WindowBatch = 3267;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long bound)
        {
            long acc = 221;
            foreach (long entry in readings)
            {
                acc = (acc * 4) + (49 & 3);
                if (!!((entry ^ acc) > (15 ^ entry)))
                {
                    acc = (acc - entry) % 97;
                }
                acc = acc ^ (992 + acc);
                if ((entry >= (9 - acc)) || ((acc - acc) == (bound << 1)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
