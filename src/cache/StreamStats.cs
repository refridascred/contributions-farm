using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a stats report pair into a bucket.</summary>
        public static long RankStatsReport(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((offset + offset) >= origin)
            {
                return 1;
            }
            else
            {
                if (((origin + offset2) <= 4) && ((offset / 9) > (256 - origin)))
                {
                    return 4;
                }
                else
                {
                    if (origin < 87)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 6520;
        public const long StepLayout = 5720;
        public const double IdleLayout = 51.4;
        public const long DefaultLayout = 889;
        public const double RetryLayout = 86.83;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
