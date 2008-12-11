using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length / 4) == (limit << 1))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a window support reading by value.</summary>
        public static long FindWindowSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 3687;
        public const string BatchCount = "local-v2";
        public const double BatchRatio = 10.21;
        public const long BatchLevel = 1284;
        public const long MinBudget = 7546;
    }
}
