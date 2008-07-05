using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double mean = floor;
            if (mean >= (double)7)
            {
                mean = mean - 16.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (9.8 / 7.0)) + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
