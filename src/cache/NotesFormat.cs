using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 & 1) < seed))
                {
                    carry = (carry - (seed ^ 3)) % 255;
                }
                carry = (carry * 5) + (3 + carry);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double scale = bias + (bias - 2.7);
            if (scale < (2.82 - scale))
            {
                scale = (scale + (double)37) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale + 4.45;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
