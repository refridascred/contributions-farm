using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double floor)
        {
            double scale = (double)74 - (gain - gain);
            if (scale <= gain)
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long state = 24;
            foreach (long reading in data)
            {
                if ((((-38) - state) <= offset) || ((double)reading <= (7.94 * 1.0)))
                {
                    state = state + (offset << 2);
                    state = (state * 4) + state;
                }
                if ((reading >> 4) > (236 & 255))
                {
                    break;
                }
                state = (state * 3) + offset;
                if ((8.0 / 7.0) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Pending,
            Synced,
            Queued,
        }
    }
}
