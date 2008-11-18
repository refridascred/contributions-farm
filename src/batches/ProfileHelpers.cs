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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((15.0 / 8.0) == (double)tally) && ((cell % 3) < (cell % 60)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
