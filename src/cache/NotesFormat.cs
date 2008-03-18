using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long SortCommitsFilter(long step, long floor)
        {
            if (((floor % 60) != (floor / 6)) || ((step - 511) <= floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor < (2.1 - 1.8))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (seed + state)) % 1000;
                state = ((state * 2) + (seed + seed)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
