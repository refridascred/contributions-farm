using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = ((state - (limit - limit)) % 255) + cell;
            }
            return state;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((mix & 31) != ((long)readings.Length & 15))
                {
                    mix = ((mix - (mix ^ 9)) % 4096) - reading;
                }
            }
            return mix % 1000;
        }
    }
}
