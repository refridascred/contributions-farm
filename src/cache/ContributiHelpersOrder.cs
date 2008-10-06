using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long acc = -75;
            foreach (long reading in series)
            {
                if (!((67 & 255) > reading))
                {
                    acc = (acc * 3) + ((long)series.Length - acc);
                }
                else
                {
                    acc = (acc + (reading + reading)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = (acc << 2) ^ (acc - 553);
            }
            return acc % 4096;
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
