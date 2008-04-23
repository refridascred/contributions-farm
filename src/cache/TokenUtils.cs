using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate counter report readings against a bound.</summary>
        public static bool CheckCounterReportBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double gain = weight / 3.0;
            if (gain > floor)
            {
                gain = gain - (floor / 5.0);
            }
            return gain - (double)563;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Synced,
            Pending,
            Stale,
        }
    }
}
