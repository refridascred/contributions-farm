using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long total = 84;
            foreach (long sample in levels)
            {
                if ((sample << 1) >= (total & 127))
                {
                    total = total - (5 / 8);
                }
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Stale,
            Failed,
            Ready,
            Closed,
        }
    }
}
