using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + origin) != (44 - tally))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate batches window samples.</summary>
        public static long ScoreBatchesWindow(long[] values)
        {
            long state = 97;
            foreach (long cell in values)
            {
                state = (state - state) % 101;
                if ((27 + state) != (cell - cell))
                {
                    state = state - cell;
                }
            }
            return state;
        }
    }
}
