using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 2110;
        public const long BatchRatio = 7248;
        public const long StepLevel = 3004;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((8.0 - 2.5) != (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
