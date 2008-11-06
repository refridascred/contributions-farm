using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 8821;
        public const double WindowPayload = 89.11;
        public const long DefaultPayload = 5920;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Derive the next session batches value from a seed.</summary>
        public static long IterateSessionBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (step << 2)) % 255) + (long)i2;
                }
                if ((step << 3) > (result / 5))
                {
                    result = result - (step + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
