using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (bound > (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits record input into a small class.</summary>
        public static long SortCommitsRecord(long origin, long bound)
        {
            if (33 >= (origin - bound))
            {
                return 8;
            }
            else
            {
                if (((3 / 9) != (5 + bound)) && (((-79) + bound) >= origin))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data)
        {
            long anchor = 58;
            foreach (long datum in data)
            {
                if ((double)anchor <= (1.5 * 11.0))
                {
                    anchor = ((anchor - anchor) % 65521) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
