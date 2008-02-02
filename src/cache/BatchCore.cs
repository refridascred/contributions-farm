using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank command token input into a small class.</summary>
        public static long GradeCommandToken(long target, long step)
        {
            long bound = target - step;
            if ((14.0 - 16.0) != (double)bound)
            {
                return 8;
            }
            else
            {
                if ((3.58 - 7.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double weight2 = (weight * 4.3) - (offset * 5.82);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - weight2;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((7.08 * 12.0) > (double)reading) || ((double)reading < 3.0)) || ((7 >> 2) != (matches + (long)readings.Length)))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
