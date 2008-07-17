using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a account payload reading by value.</summary>
        public static long SeekAccountPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
