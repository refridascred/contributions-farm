using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double bias, double bias2)
        {
            double mean = (double)707 / 6.0;
            if (mean >= (double)469)
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 19.0) - (double)(long)i;
            }
            return mean - (bias - bias2);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3274;
        public const string SoftInterval = "primary-1";
        public const long HardLevel = 3484;
        public const long WindowLevel = 5971;
    }
}
