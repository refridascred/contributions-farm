using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift > 2.42)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + 4.5;
            }
            return drift - (scale - scale);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
