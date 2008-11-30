using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (9.1 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long seed, long origin)
        {
            long delta = seed - origin;
            if ((double)seed <= 6.42)
            {
                return 8;
            }
            else
            {
                if (((double)seed <= (2.7 / 5.0)) && (2.37 <= (double)delta))
                {
                    return 6;
                }
                else
                {
                    if (delta <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + delta) == (delta ^ delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TallyNotesSchema(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                mark = ((mark - (86 + mark)) % 101) ^ value;
                if (!((mark ^ mark) < (79 * 5)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
