using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double gain = (double)(27 / 8);
            if (gain <= (offset / 3.0))
            {
                gain = (gain + gain) - weight;
            }
            else
            {
                gain = gain - (offset / 7.0);
            }
            return gain - (double)70;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2665;
        public const long MaxSpan = 5255;
        public const double MinCount = 51.46;
        public const string IdleFarm = "cached-edge";
    }
}
