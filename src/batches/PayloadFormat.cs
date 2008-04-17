using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value == (2.75 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
