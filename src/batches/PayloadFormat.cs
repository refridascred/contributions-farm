using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((floor + floor) != ((-5) + floor)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((-4) >= (matches - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Stale,
            Failed,
            Synced,
        }
    }
}
