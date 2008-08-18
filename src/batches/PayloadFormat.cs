using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a token filter counter forward.</summary>
        public static long RollTokenFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + step;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
