using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items, long offset)
        {
            long acc = 546;
            foreach (long sample in items)
            {
                if (!(offset <= sample))
                {
                    acc = (acc + 930) % 65521;
                }
                if ((offset >> 4) == (acc - 85))
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc + (2 / 2)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
