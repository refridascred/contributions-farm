using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 39;
            foreach (long sample in data)
            {
                if ((double)state > (double)sample)
                {
                    state = (state - sample) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)599 <= (double)value) || (value < (seen % 7))) || ((double)seen == (5.0 + 2.4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
