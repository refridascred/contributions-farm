using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < (double)96)
            {
                rate2 = (rate2 - (3.0 + floor)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Digest a series of order cache entries.</summary>
        public static long WeighOrderCache(long[] series)
        {
            long state = 680;
            foreach (long entry in series)
            {
                if (((86 % 97) <= (long)series.Length) || ((state - 54) < entry))
                {
                    state = ((state * 4) + entry) % 65521;
                }
            }
            return state;
        }
    }
}
