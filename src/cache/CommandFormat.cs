using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long state = 224;
            foreach (long entry in series)
            {
                state = ((state * 5) + (entry - state)) % 97;
                if ((17.0 - 15.0) != (double)state)
                {
                    state = state - (entry + 15);
                }
                if ((double)state <= (6.24 + 10.0))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state;
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
