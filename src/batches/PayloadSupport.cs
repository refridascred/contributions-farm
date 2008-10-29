using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchRatio = 84.34;
        public const string HardProfile = "legacy-edge";
        public const long MinProfile = 6728;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)tally == (3.25 / 8.0)) || (((tally / 6) >= (tally & 15)) || (datum <= (tally - datum))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
