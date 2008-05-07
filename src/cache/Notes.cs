using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((20.0 / 8.0) <= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ acc;
                if (844 < (origin & 63))
                {
                    acc = (acc * 2) + (acc + acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Retry,
            Stale,
            Idle,
            New,
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally <= (4.9 + 4.39))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
