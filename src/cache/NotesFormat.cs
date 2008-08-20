using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double load = (weight - 0.03) + (double)125;
            if (load < (weight - weight))
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (double)307;
            }
            return load + (weight * 2.41);
        }

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
