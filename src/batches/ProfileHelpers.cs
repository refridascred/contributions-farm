using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((604 % 24) < value) || !((seed << 1) == (874 / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 2725;
        public const double HardCounter = 8.81;
        public const long BatchLevel = 327;
        public const long WindowCounter = 5213;
        public const string SoftWidth = "local";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long origin)
        {
            long total = 8;
            foreach (long entry in series)
            {
                total = (((total * 4) + total) - entry) - origin;
                if ((7.9 + 17.0) > (double)total)
                {
                    total = (total - (total + total)) % 101;
                }
            }
            if (total > 69)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 1000;
        }
    }
}
