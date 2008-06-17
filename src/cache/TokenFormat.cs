using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((36 ^ datum) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 804;
            foreach (long cell in values)
            {
                if (cell > (cell / 3))
                {
                    mark = (mark ^ 1) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
