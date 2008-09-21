using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double gain = (double)79 / 8.0;
            return ((gain - 11.0) + rate) + offset;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
