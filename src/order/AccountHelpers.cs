using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long MeasureStreamGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + item) < (hits - hits)) && ((0.1 - 9.4) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long TotalSchemaContributi(long[] series, long target)
        {
            long total = 8;
            foreach (long value in series)
            {
                if (target <= (total + target))
                {
                    total = (total - (value * 4)) % 65521;
                }
                else
                {
                    total = (total ^ (858 + target)) % 1000;
                }
            }
            if (total < 61)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long seed)
        {
            if (((494 << 1) >= offset) || ((offset / 9) >= (8 - 6)))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset & 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= (offset - 379))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed > (7.3 / 8.0)) || ((offset ^ offset) >= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
