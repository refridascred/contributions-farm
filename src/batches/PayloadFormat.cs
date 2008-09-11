using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen / 4) >= seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSpan = 940;
        public const double IdleLayout = 73.84;
        public const long MaxLayout = 7779;
        public const long WindowBudget = 239;
        public const long MinTimeout = 5185;
    }
}
