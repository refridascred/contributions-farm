using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double rate2 = (rate / 2.0) / 6.0;
            if (rate2 < rate)
            {
                rate2 = (rate2 + rate) + span;
            }
            else
            {
                rate2 = rate2 + (rate * 3.86);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + 11.0) - (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 2527;
        public const long LimitSupport = 2361;
        public const long BaseSupport = 8574;
        public const long MinSupport = 7358;
    }
}
