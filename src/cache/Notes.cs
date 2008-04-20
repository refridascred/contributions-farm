using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long anchor = 780;
            foreach (long datum in series)
            {
                anchor = ((anchor << 2) ^ floor) ^ datum;
                anchor = (anchor * 3) + (5 - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long FoldToolsChecks(long[] data, long floor)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if ((acc - acc) < item)
                {
                    acc = ((acc + (item + item)) % 101) - floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit buffer channel readings against a rule.</summary>
        public static long CountBufferChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((6.0 / 8.0) != (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value <= (19 % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
