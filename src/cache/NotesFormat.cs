using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long limit)
        {
            long cur = step ^ limit;
            if (((1.0 + 16.0) < (double)cur) || ((cur / 2) < (limit << 3)))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) == (step >> 4)) && ((0.6 / 4.0) != (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 24) >= (step % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double mean = scale;
            if (mean < (scale / 5.0))
            {
                mean = (mean + (scale / 9.0)) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (scale - mean)) - (double)(long)i;
            }
            return mean + (double)589;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
