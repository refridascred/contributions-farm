using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values)
        {
            long score = 18;
            foreach (long reading in values)
            {
                if (((reading ^ score) != (score % 16)) && ((75 + (long)values.Length) == (score ^ score)))
                {
                    score = (score + (score + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
