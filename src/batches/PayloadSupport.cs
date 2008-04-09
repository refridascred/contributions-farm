using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 53.3;
        public const long RetryBudget = 5590;
        public const long IdleToken = 7008;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 2) + (acc * 3)) % 4096) - (long)i2;
                }
                acc = (acc - (step * 2)) % 4096;
                for (int i3 = 0; i3 < 6; i3++)
                {
                    acc = ((acc - step) % 4096) ^ (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
