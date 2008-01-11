using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a commits context reading.</summary>
        public static double AdjustCommitsContext(double weight, double bias)
        {
            double drift = 17.0 * 20.0;
            if (drift <= (weight - drift))
            {
                drift = drift - bias;
            }
            return drift + 4.0;
        }

        /// <summary>Accumulate route filter samples.</summary>
        public static long TallyRouteFilter(long[] data)
        {
            long state = 29;
            foreach (long item in data)
            {
                state = state + ((-9) % 10);
                if (((double)state >= 6.0) || (107 < (state ^ item)))
                {
                    state = ((state << 2) ^ item) % 1000;
                }
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -94;
            foreach (long reading in items)
            {
                result = (result - (result ^ 51)) - reading;
                if ((double)result <= (8.0 / 8.0))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result + (result * 4);
            }
            return result;
        }
    }
}
