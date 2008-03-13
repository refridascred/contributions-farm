using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset % 8) < seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "standard";
        public const long StepCounter = 2564;
        public const long HardSpan = 292;
        public const string IdleTimeout = "legacy";

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double mean = (double)(8 / 3);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (floor + mean)) - (double)(long)i) - scale;
            }
            return mean - (mean / 4.0);
        }
    }
}
