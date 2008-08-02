using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context farm entry stays within the limit.</summary>
        public static bool ValidateContextFarmLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = scale * 2.7;
            if (mean <= (mean - mean))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (double)255;
            }
            return mean - floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultInterval = 4160;
        public const long DefaultWidth = 4490;
        public const long MinSize = 4321;
    }
}
