using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - tally) > (offset * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (bias - 3.4))
            {
                bias2 = (bias2 + bias2) + floor;
            }
            else
            {
                bias2 = bias2 + 4.0;
            }
            return bias2 + (6.1 * 6.88);
        }
    }
}
