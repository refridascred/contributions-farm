using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long limit)
        {
            if ((limit << 3) == (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((6.1 / 5.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (13.0 * 3.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value + seen) > (38 - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
