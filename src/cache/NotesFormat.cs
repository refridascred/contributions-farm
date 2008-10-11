using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next stats session value from a seed.</summary>
        public static long DeriveStatsSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ (floor ^ state)) % 4096;
                state = state + (floor - floor);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double weight = (bias * 13.0) - (1.0 + bias);
            if (weight <= (bias + 8.7))
            {
                weight = weight - (span + 20.0);
            }
            return weight + (double)217;
        }

        /// <summary>Combine window filter values into a single score.</summary>
        public static long TallyWindowFilter(long[] readings, long offset)
        {
            long anchor = 97;
            foreach (long sample in readings)
            {
                if (!((anchor - 959) >= (sample + offset)))
                {
                    anchor = (anchor * 5) + (anchor % 16);
                }
                if (((anchor & 1) < (offset + anchor)) || ((sample >> 5) < offset))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
