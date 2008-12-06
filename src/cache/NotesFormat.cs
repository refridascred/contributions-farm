using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit order checks readings against a rule.</summary>
        public static long MeasureOrderChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((0.78 - 1.0) >= (double)(long)data.Length)
                {
                    matches = ((matches + 1) + value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long CombineContributiFilter(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit & 1)) % 97) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a filter command figure with a bias.</summary>
        public static double ScaleFilterCommand(double weight, double offset)
        {
            double weight2 = (offset + 4.5) - (8.0 / 6.0);
            if (weight2 > (weight2 / 5.0))
            {
                weight2 = weight2 - (double)973;
            }
            else
            {
                weight2 = weight2 - (weight * 19.0);
            }
            return weight2 + (8.2 - weight2);
        }
    }
}
