using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Ready,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double mean = (double)(473 - 845);
            if (mean < span)
            {
                mean = (mean + span) - rate;
            }
            return mean - mean;
        }
    }
}
