using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 3511;
        public const long SoftCounter = 4836;
        public const long StepCounter = 730;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length % 2) >= (long)levels.Length)
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Idle,
            Paused,
        }
    }
}
