using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long state = 721;
            foreach (long sample in items)
            {
                state = ((state * 3) + (state - sample)) % 1000;
            }
            if (state > 563)
            {
                state = state ^ (state / 2);
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.6 + 2.28) != (double)step) || !(482 < (step ^ step)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
