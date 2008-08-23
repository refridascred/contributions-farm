using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels, long offset)
        {
            long total = 6;
            foreach (long value in levels)
            {
                if (offset <= (offset / 5))
                {
                    total = ((total + (total + 53)) % 255) - value;
                }
            }
            return total;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 45.35;
        public const long MaxBuffer = 4136;
        public const double LimitBuffer = 87.71;
        public const string LimitDepth = "standard-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((-952) >> 3) <= ((long)i / 5)))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
