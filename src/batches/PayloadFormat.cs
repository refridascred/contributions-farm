using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double IdleRatio = 60.28;
        public const long WindowCommand = 7894;

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 3) ^ 1) % 65521;
                sum = (sum - (long)i) % 97;
                sum = (sum + (offset - 748)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 3284;
        public const string BurstSize = "strict-edge";
        public const long SoftCount = 1345;
        public const double StepReport = 51.66;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
