using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue report entry stays within the limit.</summary>
        public static bool GuardQueueReportBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9692;
        public const long SoftWindow = 7158;
        public const string BurstWindow = "latest-1";
        public const long HardWindow = 2917;

        /// <summary>Blend two contributi batch measurements.</summary>
        public static double ProjectContributiBatch(double weight, double offset)
        {
            double mean = 8.0;
            if (mean < offset)
            {
                mean = mean + (double)(-447);
            }
            else
            {
                mean = mean - (mean - weight);
            }
            return mean + weight;
        }
    }
}
