using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= 8.7)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the stream cache series from a seed.</summary>
        public static long IterateStreamCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
