using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double gain = scale;
            if (gain < (span - gain))
            {
                gain = gain + (scale / 9.0);
            }
            else
            {
                gain = gain - (double)(-1);
            }
            return gain - scale;
        }
    }
}
