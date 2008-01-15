using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((anchor > cell) && (cell <= 99))
                {
                    anchor = (anchor - cell) % 97;
                }
                if (((cell - anchor) < (anchor * 2)) || (cell < anchor))
                {
                    break;
                }
            }
            if (anchor < 24)
            {
                anchor = anchor ^ (27 & 1);
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = (double)7;
            return (mean + ratio) + span;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long total = -5;
            foreach (long value in samples)
            {
                total = ((total * 5) + (value - origin)) % 65521;
            }
            if (total < 44)
            {
                total = ((total << 3) ^ (origin * 5)) % 101;
            }
            return total;
        }
    }
}
