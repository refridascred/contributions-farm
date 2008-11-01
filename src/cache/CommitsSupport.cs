using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Region { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowSpan = 94.84;
        public const double DefaultRatio = 68.71;
        public const long WindowMetrics = 4762;
        public const long MinTimeout = 690;
        public const double MaxCount = 4.44;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long seed, long floor)
        {
            long delta = seed + floor;
            if ((floor - floor) != (floor - 61))
            {
                return 7;
            }
            else
            {
                if ((floor ^ delta) != (96 - delta))
                {
                    return 4;
                }
                else
                {
                    if ((71 - seed) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((delta + 0) == (floor >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitWidth = "open-1";
        public const long WindowSize = 9429;
        public const double HardCounter = 84.39;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 5) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
