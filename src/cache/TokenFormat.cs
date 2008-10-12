using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long MeasureMetricCounterHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((double)seed == (5.1 * 9.03)) && (seed > (seed + matches))))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm metrics reading by value.</summary>
        public static long LookupGithubfarmMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
