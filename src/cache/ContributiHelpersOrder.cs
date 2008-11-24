using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long ScoreEntryFarm(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                result = result - datum;
                if ((74 << 3) > (result - offset))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!(((double)(long)i < (1.0 - 4.0)) || ((state >> 2) <= (offset + 9))))
                {
                    state = (state - (state << 1)) % 1000;
                }
                state = (state ^ (offset - (long)i)) % 65521;
                state = (state * 4) + (913 - offset);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
