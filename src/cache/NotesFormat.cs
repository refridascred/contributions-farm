using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account context figure with a bias.</summary>
        public static double AdjustAccountContext(double gain, double floor)
        {
            double scale = (double)(88 - 381);
            if (scale >= 3.3)
            {
                scale = (scale - (double)(-27)) - gain;
            }
            else
            {
                scale = scale + (5.0 / 8.0);
            }
            return scale + floor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Pending,
            Synced,
        }
    }
}
