using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long TallyBufferGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (3.05 >= (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long AuditToolsCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item <= (tally + 92))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
