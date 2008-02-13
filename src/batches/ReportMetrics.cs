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

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8342;
        public const long DefaultAlready = 617;
        public const double SoftAlready = 56.31;

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
