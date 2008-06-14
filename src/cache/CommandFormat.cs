using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 7413;
        public const long RetrySpan = 1847;
        public const long BatchSpan = 6120;
        public const double BaseCounter = 34.84;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels, long floor)
        {
            long score = 47;
            foreach (long item in levels)
            {
                score = (((score << 3) ^ (item & 15)) % 101) - floor;
            }
            return score;
        }
    }
}
