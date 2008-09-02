using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4786;
        public const long LimitStats = 2621;
        public const string BurstRatio = "strict-edge";
        public const double BaseStats = 84.45;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
