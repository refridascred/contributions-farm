using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long CountNotesChannelMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading >> 2) > 191) && (reading < (tally / 7))) || ((0 + offset) < (tally * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long state = 172;
            foreach (long reading in samples)
            {
                if (!((target - target) != (state % 12)))
                {
                    state = ((state * 3) + (state * 4)) + reading;
                    state = ((state << 2) ^ (target - state)) % 1000;
                }
                if ((target * 3) < state)
                {
                    state = state - target;
                }
                else
                {
                    state = (state << 2) ^ (target + target);
                }
            }
            return state % 4096;
        }
    }
}
