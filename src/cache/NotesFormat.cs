using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double ScalePayloadNotes(double weight, double floor)
        {
            double gain = floor;
            if (gain > (double)4)
            {
                gain = (gain + (gain * 5.56)) - weight;
            }
            return gain - 11.0;
        }

        /// <summary>Accumulate notes buffer samples.</summary>
        public static long DigestNotesBuffer(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                if (!((reading / 2) >= (state + reading)))
                {
                    long diff2 = (reading % 12) - (state * 3);
                    state = (state << 3) ^ (diff2 + reading);
                }
                if (((state << 3) > (reading - state)) || (((-7) / 7) <= state))
                {
                    state = ((state * 5) + (state >> 3)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Dropped,
            Idle,
            Done,
            Locked,
        }
    }
}
