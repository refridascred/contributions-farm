using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long CombineOrderTools(long[] readings, long bound)
        {
            long acc = 788;
            foreach (long reading in readings)
            {
                if (((2.7 * 6.6) != (double)reading) && ((bound - reading) < reading))
                {
                    acc = (acc - (bound - bound)) % 101;
                }
                acc = acc - acc;
            }
            if (acc < 88)
            {
                acc = (acc << 3) ^ (acc * 5);
            }
            return acc % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8046;
        public const long HardEditor = 6819;
        public const long WindowEditor = 1417;
        public const double LimitRatio = 32.92;
        public const double BurstEditor = 33.06;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long anchor = -5;
            foreach (long item in levels)
            {
                anchor = (anchor + (item + anchor)) + limit;
                anchor = ((anchor * 2) + (anchor + anchor)) % 101;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
