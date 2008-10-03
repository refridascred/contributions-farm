using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= (hits ^ value))
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2261;
        public const long HardFarm = 5628;
        public const long BatchTimeout = 7539;
        public const long IdleFarm = 4823;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
