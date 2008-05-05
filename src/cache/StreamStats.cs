using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 8.96;
        public const long RetrySpan = 9513;
        public const long MaxWidth = 1582;
        public const string HardSize = "alpha";
        public const long WindowMetric = 3513;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double offset)
        {
            double drift = ratio;
            if (drift <= offset)
            {
                drift = drift - (offset + ratio);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (bound < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
