using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc + step)) % 255;
                acc = (acc ^ (step + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
