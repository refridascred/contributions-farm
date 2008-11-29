using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSize = 994;
        public const long CacheGraph = 2840;
        public const long BatchGraph = 8966;
        public const double IdleDepth = 54.87;
        public const double RetryGraph = 15.99;

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (total << 1)) % 4096;
                if ((step + (long)i) < (step - step))
                {
                    total = total - (step * 3);
                }
                else
                {
                    total = total + (step - step);
                    total = (total ^ (step / 6)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
