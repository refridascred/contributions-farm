using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long total = 512;
            foreach (long reading in samples)
            {
                total = (((total * 5) + total) ^ reading) + limit;
            }
            if (total < 890)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value > (value / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
