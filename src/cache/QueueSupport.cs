using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstFactor = 8792;
        public const string StepRatio = "legacy-1";
        public const double MinSize = 29.71;
        public const long SoftEditor = 1809;

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long MeasureCommandGraphGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((0 * 4) > entry)
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
