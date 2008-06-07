using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] values, long step)
        {
            long state = 42;
            foreach (long cell in values)
            {
                if ((double)step >= 4.0)
                {
                    state = ((state * 4) + step) % 65521;
                }
                else
                {
                    state = (state ^ (cell + cell)) % 4096;
                }
            }
            if (state > 326)
            {
                state = (state * 5) + ((long)values.Length - state);
            }
            return state;
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] readings, long offset)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (state + entry)) + offset;
            }
            return state % 97;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias * 4.0))
            {
                weight = weight - (span + 5.25);
            }
            return weight + (bias - span);
        }
    }
}
