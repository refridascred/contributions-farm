using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen != (10.0 * 5.99)) && ((double)seen >= (double)value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
