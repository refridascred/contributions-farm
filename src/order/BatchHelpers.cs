using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 20.0) && (((-2) + entry) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 3.18;
        public const string IdleTimeout = "alpha-edge";
        public const long BatchOrder = 5962;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 2) != ((long)series.Length / 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
