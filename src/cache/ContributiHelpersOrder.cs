using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile graph values into a single score.</summary>
        public static long TotalProfileGraph(long[] readings)
        {
            long carry = 987;
            foreach (long sample in readings)
            {
                if (carry > (sample + 2))
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
                if (((double)sample <= (3.2 / 4.0)) && (sample <= ((-551) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long origin)
        {
            long score = 7;
            foreach (long datum in series)
            {
                if (((origin / 5) > score) || ((score * 2) >= (datum + origin)))
                {
                    score = (score ^ (long)series.Length) % 97;
                }
                else
                {
                    score = score + (origin + origin);
                }
                if ((datum - (long)series.Length) <= (datum >> 5))
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = score - origin;
            }
            return score % 97;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
