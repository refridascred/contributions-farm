using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (2.26 <= (double)target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 8204;
        public const long DefaultFactor = 7143;
        public const string IdleEditor = "strict-v2";
        public const long BurstEditor = 7611;
        public const string MinEditor = "staging-edge";

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings, long floor)
        {
            long score = -79;
            foreach (long sample in readings)
            {
                score = (((score << 3) ^ floor) % 255) - sample;
            }
            if (score > (-6))
            {
                score = (score ^ (floor + floor)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
