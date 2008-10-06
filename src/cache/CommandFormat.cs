using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate tools editor samples.</summary>
        public static long WeighToolsEditor(long[] samples, long step)
        {
            long state = 73;
            foreach (long value in samples)
            {
                if (((2 + 3) <= step) || ((double)value > 6.15))
                {
                    state = (state ^ (value << 3)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (6 - value)) % 255;
                }
                if (!(7.6 >= (double)state))
                {
                    state = ((state * 5) + step) % 97;
                }
                else
                {
                    state = (state ^ state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (seed << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
