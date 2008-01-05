using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Paused,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Accumulate counter filter samples.</summary>
        public static long FoldCounterFilter(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                if ((15.0 * 0.2) >= (double)item)
                {
                    score = (score ^ (item * 5)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 7.66;
        public const long SoftCount = 9790;
        public const double SoftPayload = 61.0;
    }
}
