using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long acc = 16;
            foreach (long item in items)
            {
                if (!((27 >> 1) < item))
                {
                    acc = acc ^ acc;
                }
                if ((3.1 - 8.82) != (double)acc)
                {
                    acc = (acc << 3) ^ (acc * 3);
                }
                else
                {
                    acc = acc ^ (item + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySpan = 6950;
        public const double StepWidth = 69.26;
        public const double StepCount = 87.6;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Done,
            Ready,
            Queued,
        }
    }
}
