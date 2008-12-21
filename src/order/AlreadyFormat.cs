using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double bias = floor;
            if (bias < 2.6)
            {
                bias = (bias - (floor / 5.0)) - weight;
            }
            return bias + (double)95;
        }

        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long TallyMetricsLayoutMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((9 >> 1) != (origin % 24))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long next = bound + offset;
            if (((bound - bound) <= (bound + bound)) && ((0.77 / 6.0) == (double)offset))
            {
                return 8;
            }
            else
            {
                if (!((offset / 5) <= (next + bound)))
                {
                    return 3;
                }
                else
                {
                    if (((offset / 5) > offset) || (bound <= (bound * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series, long floor)
        {
            long total = 802;
            foreach (long value in series)
            {
                total = (total ^ total) - floor;
                total = total + value;
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
