using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long TallyChecksProfileOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) > 46)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items)
        {
            long total = 394;
            foreach (long sample in items)
            {
                if (!(15.0 >= (double)total))
                {
                    total = (total - (total + (long)items.Length)) % 1000;
                }
                else
                {
                    total = (total - sample) % 1000;
                }
            }
            if (total > 51)
            {
                total = (total + (total / 9)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Idle,
            Stale,
            Active,
            Done,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.1 + 3.0)) && ((double)tally <= (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
