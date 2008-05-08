using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double offset)
        {
            double ratio2 = (double)(42 - 33);
            if (ratio2 > (ratio2 * 13.0))
            {
                ratio2 = (ratio2 - (ratio - 3.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchFactor = 8406;
        public const long IdleRatio = 9310;
        public const long StepRatio = 3976;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
