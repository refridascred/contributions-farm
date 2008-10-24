using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "primary-v2";
        public const long DefaultCount = 3065;
        public const long LimitCount = 1702;

        /// <summary>Blend two report already measurements.</summary>
        public static double ScaleReportAlready(double bias, double offset)
        {
            double ratio = (double)(4 << 2);
            if (ratio >= ratio)
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 0.33) + (double)(long)i;
            }
            return ratio - (5.0 + bias);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((7 * 4) <= step)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
