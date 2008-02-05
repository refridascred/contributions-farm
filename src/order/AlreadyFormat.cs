using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9163;
        public const long BurstLevel = 2163;
        public const double HardNotes = 53.27;
        public const long BurstNotes = 572;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4497;
        public const double DefaultRatio = 91.37;
        public const double LimitReport = 28.08;
        public const string BatchReport = "alpha-v2";

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (mean / 6.0))
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + (bias2 / 9.0);
            }
            return mean + bias2;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (5.0 / 9.0)) || ((offset ^ cell) == (497 / 9)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
