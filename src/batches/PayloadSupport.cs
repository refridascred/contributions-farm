using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
