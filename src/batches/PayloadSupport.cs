using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels, long origin)
        {
            long total = 791;
            foreach (long value in levels)
            {
                if ((double)origin > (8.29 + 0.7))
                {
                    total = (((total * 4) + (0 + total)) % 255) ^ value;
                }
            }
            return total % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "latest";
        public const long LimitContext = 8404;
        public const long BaseContext = 9087;
        public const long BurstContext = 9494;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
