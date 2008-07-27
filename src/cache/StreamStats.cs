using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long SeriesCommandFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                long bound = mark * 5;
                if ((origin >> 3) >= bound)
                {
                    bound = bound - 599;
                }
                else
                {
                    mark = (mark << 3) ^ ((long)i * 2);
                }
                bound = (bound << 3) ^ (mark + bound);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally % 97) <= (tally % 5))
                {
                    tally = ((tally + 1) ^ item) + origin;
                }
            }
            return tally;
        }
    }
}
