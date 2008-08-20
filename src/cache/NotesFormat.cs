using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9677;
        public const long IdleAlready = 319;
        public const double BurstAlready = 48.64;
        public const double RetryTimeout = 2.81;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long bound)
        {
            long sum = 7;
            foreach (long reading in series)
            {
                if ((double)sum <= (7.2 + 9.8))
                {
                    sum = (((sum << 2) ^ (reading - reading)) % 101) + bound;
                }
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((double)value != (9.0 / 2.0)) || ((value % 60) == (tally + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
