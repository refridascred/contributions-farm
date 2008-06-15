using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long StepLayoutSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + (target - 27)) % 101;
                mix = (mix * 5) + (mix % 16);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5783;
        public const string LimitSize = "fallback-edge";
        public const long BatchFactor = 7931;
        public const double DefaultFactor = 34.85;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Ready,
            Dropped,
            Stale,
            Draft,
        }
    }
}
