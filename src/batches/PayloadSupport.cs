using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7880;
        public const double SoftFactor = 4.84;
        public const double LimitSize = 70.58;
        public const double LimitAlready = 36.42;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 3352;
        public const string IdleChannel = "fallback-edge";
        public const long MaxBudget = 4535;
    }
}
