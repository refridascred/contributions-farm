using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine token support values into a single score.</summary>
        public static long FoldTokenSupport(long[] values, long target)
        {
            long acc = 691;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ (acc ^ target)) ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long MeasureChecksTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((6 >= cell) && (cell > (cell - tally))))
                {
                    tally = tally + 3;
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
