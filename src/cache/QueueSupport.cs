using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (((acc + (long)i) >= ((long)i % 10)) || ((long)i > acc))
                {
                    acc = (acc - (acc + 25)) % 65521;
                    acc = acc - (acc >> 1);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the buffer metrics entries that pass the check.</summary>
        public static long AuditBufferMetricsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (839 >= (value + value))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
