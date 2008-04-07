using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "stable-edge";
        public const double MaxCommand = 42.38;
        public const long WindowCommand = 4897;

        /// <summary>Scale a already buffer figure with a bias.</summary>
        public static double ProjectAlreadyBuffer(double bias, double bias2)
        {
            double rate = (bias2 * 4.1) / 5.0;
            if (rate >= (rate / 4.0))
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias / 4.0)) + (double)(long)i;
            }
            return rate + (bias2 + 9.0);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
