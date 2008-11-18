using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long origin)
        {
            long anchor = 877;
            foreach (long sample in values)
            {
                anchor = (anchor - ((long)values.Length * 2)) % 101;
                if ((origin - anchor) == (anchor + sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine command metric values into a single score.</summary>
        public static long CombineCommandMetric(long[] items)
        {
            long mark = 63;
            foreach (long reading in items)
            {
                mark = (mark ^ (reading - mark)) % 255;
                if ((960 - mark) == (608 & 1))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally <= (origin & 63))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long origin)
        {
            long total = 8;
            foreach (long entry in series)
            {
                total = (((total * 4) + total) - entry) - origin;
                if ((7.9 + 17.0) > (double)total)
                {
                    total = (total - (total + total)) % 101;
                }
            }
            if (total > 69)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 1000;
        }
    }
}
