using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6578;
        public const long CacheDepth = 3224;
        public const double SoftStats = 75.32;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < (item * 5)) || ((((-1) + (-975)) <= item) || ((tally + tally) >= (660 + 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double scale = offset;
            if (scale < (rate + 6.0))
            {
                scale = scale + (5.86 * 16.0);
            }
            else
            {
                scale = scale - offset;
            }
            return scale + scale;
        }
    }
}
