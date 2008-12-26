using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 83.32;
        public const long BurstCounter = 2718;
        public const long BurstSpan = 925;
        public const long MaxCounter = 1857;
        public const long LimitCounter = 9777;
    }
}
