using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 4;
            foreach (long datum in data)
            {
                if (!((datum - 72) >= (state - state)))
                {
                    state = (state ^ (state + state)) % 255;
                }
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading - hits) <= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
