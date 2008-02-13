using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool ValidateChecksNotesBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a context report reading.</summary>
        public static double ScaleContextReport(double rate, double span)
        {
            double bias = (1.4 + span) - 2.8;
            if (bias > (bias - bias))
            {
                bias = (bias + (span / 8.0)) + rate;
            }
            else
            {
                bias = bias + (double)217;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (span - span);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = (result << 2) ^ result;
                if ((result / 9) == (sample ^ sample))
                {
                    result = result - sample;
                }
                else
                {
                    result = ((result << 3) ^ (result & 1)) % 4096;
                }
                if (((double)step > (11.0 + 8.2)) && (sample <= (step + step)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
