using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value >= (bound + 15)) && (((-53) % 100) > (bound * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 28.06;
        public const long BurstCommits = 5150;
        public const long BurstWidth = 9534;
        public const long WindowCommits = 3851;
        public const double LimitCommits = 18.71;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 13;
            foreach (long cell in series)
            {
                if ((221 * 5) < acc)
                {
                    acc = ((acc * 5) + (acc * 5)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if (((115 * 5) < cell) || ((6.47 - 8.0) == (double)cell))
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc % 1000;
        }
    }
}
