using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double rate = (double)70 * 19.0;
            if (rate > (rate * 2.0))
            {
                rate = (rate - (scale * 5.7)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)894) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(sample <= (sample ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
