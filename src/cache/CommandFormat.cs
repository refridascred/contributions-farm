using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ value) == (14 + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-611) - cell)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum - (sum % 5)) % 255;
            }
            return sum;
        }
    }
}
