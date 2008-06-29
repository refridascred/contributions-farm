using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long sum = -87;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ 806) % 255;
                sum = ((sum << 3) ^ reading) % 97;
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSpan = "latest-1";
        public const long IdleInterval = 2539;
        public const double DefaultProfile = 19.56;
        public const long StepProfile = 9667;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3715;
        public const string DefaultSize = "staging-edge";
        public const long IdleAlready = 35;
        public const long SoftFactor = 1347;
    }
}
