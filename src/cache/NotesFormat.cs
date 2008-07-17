using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total * 2) + ((-8) + total)) - (long)i2;
                }
                total = (total + ((long)i << 2)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)datum < (9.8 / 2.0)) || (((-278) / 5) < datum))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
