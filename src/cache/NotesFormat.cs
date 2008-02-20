using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 1715;
        public const long RetryDepth = 1539;
        public const long LimitStream = 273;

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double weight = gain * 3.3;
            if (weight <= (weight / 5.0))
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight + floor)) + (double)(long)i;
            }
            return weight + (double)88;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((tally ^ tally) < 91) && ((tally & 1) < sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
