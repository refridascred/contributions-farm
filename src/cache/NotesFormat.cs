using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 + offset) + bias;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long anchor = 954;
            foreach (long reading in series)
            {
                anchor = ((anchor * 4) + (reading + anchor)) % 97;
                if ((anchor / 2) < (reading - anchor))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor ^ (reading << 3);
                }
            }
            if (anchor < 603)
            {
                anchor = (anchor ^ (anchor << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long offset)
        {
            long state = 52;
            foreach (long reading in series)
            {
                if ((2 & 127) != (offset & 31))
                {
                    state = (((state << 3) ^ (state * 2)) % 97) - reading;
                }
            }
            return state;
        }
    }
}
