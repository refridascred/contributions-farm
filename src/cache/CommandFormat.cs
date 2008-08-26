using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double scale = (double)(9 + 1);
            if (scale <= weight)
            {
                scale = (scale - scale) - floor;
            }
            else
            {
                scale = scale + (5.2 - 18.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + (double)308;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long TotalStreamQueue(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = carry + (value / 9);
            }
            return carry % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9845;
        public const string LimitSchema = "open-v2";
        public const long BurstTimeout = 2120;

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long anchor = -64;
            foreach (long datum in data)
            {
                if ((double)anchor <= (0.3 / 2.0))
                {
                    anchor = ((anchor - anchor) % 255) - datum;
                }
            }
            return anchor;
        }
    }
}
