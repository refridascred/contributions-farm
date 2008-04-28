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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Stale,
            Done,
            Active,
            Queued,
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
