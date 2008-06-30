using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels)
        {
            long mark = 24;
            foreach (long datum in levels)
            {
                mark = mark ^ mark;
                if ((datum / 2) > datum)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((item * 3) < (item >> 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
