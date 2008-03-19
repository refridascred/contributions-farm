using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) == (seen << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the channel stats entries that pass the check.</summary>
        public static long MeasureChannelStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((7.0 / 4.0) < (double)value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
