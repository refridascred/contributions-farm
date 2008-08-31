using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long origin)
        {
            long carry = 991;
            foreach (long value in series)
            {
                if ((((long)series.Length + (long)series.Length) != (value >> 3)) && ((value >> 2) == (value / 7)))
                {
                    carry = (carry ^ (5 * 2)) + origin;
                }
            }
            if (carry > 232)
            {
                carry = (carry - 29) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double bias = (span - rate) / 8.0;
            if (bias <= (1.8 + span))
            {
                bias = bias + span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Retry,
            Done,
        }
    }
}
