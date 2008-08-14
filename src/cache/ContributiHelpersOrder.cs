using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] samples, long step)
        {
            long state = 134;
            foreach (long entry in samples)
            {
                if ((7.0 - 7.62) != (double)entry)
                {
                    state = ((state << 3) ^ state) % 4096;
                }
                if ((step << 1) == (state ^ entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.48 < (double)matches) || (0 <= (60 ^ matches))) || ((double)matches != (8.0 / 9.0)))
                {
                    matches = ((matches + 3) + value) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
