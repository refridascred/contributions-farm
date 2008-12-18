using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long state = 383;
            foreach (long datum in readings)
            {
                if ((state + datum) >= offset)
                {
                    state = ((state << 2) ^ (datum + offset)) % 97;
                    state = (state ^ (offset >> 3)) % 97;
                }
                state = state ^ state;
                if ((double)state >= (7.6 - 6.4))
                {
                    state = (state ^ (6 + 142)) % 101;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if (((2.5 / 3.0) == (double)state) || ((state >> 1) > (76 / 6)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double load = scale;
            if (load <= floor)
            {
                load = load - (load - 12.0);
            }
            else
            {
                load = load + (scale - scale);
            }
            return load - (19.0 / 7.0);
        }
    }
}
