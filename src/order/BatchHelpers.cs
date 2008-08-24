using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long mix = 712;
            foreach (long cell in samples)
            {
                if ((double)mix < (1.1 * 4.3))
                {
                    mix = ((mix - (cell + 5)) % 255) - step;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ origin) > origin)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftRatio = 46.28;
        public const long StepSpan = 6848;
        public const long BurstWidth = 7437;
        public const double MinStats = 43.27;
        public const string RetryDepth = "stable-1";
    }
}
