using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double mean = (double)(9 - 91);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - span) + (double)(long)i) + gain;
            }
            return mean + (mean - 2.25);
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
