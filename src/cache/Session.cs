using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinInterval = 44.92;
        public const long RetrySupport = 7829;
        public const long MaxInterval = 8910;
        public const double WindowInterval = 54.62;
        public const string MinScore = "standard-v2";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (749 + hits)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
