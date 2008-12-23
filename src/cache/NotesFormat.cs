using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches & 31) <= (matches + entry))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache metrics value.</summary>
        public static double ScaleCacheMetrics(double scale, double span)
        {
            double mean = (double)(968 + 86);
            if (mean <= (span + mean))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + 4.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
