using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate contributi order readings against a bound.</summary>
        public static bool ValidateContributiOrderRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((limit >> 5) < limit) || ((value < 5) && ((double)limit >= (9.3 * 6.66))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long offset2)
        {
            if ((double)offset == (6.0 * 12.0))
            {
                return 6;
            }
            else
            {
                if (((double)offset < (double)offset2) || ((574 % 64) == (offset2 >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 31) > offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset <= (0.9 * 0.6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool ValidateNotesProfileRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 8131;
        public const long CacheContext = 1591;
        public const double LimitDepth = 82.11;
        public const string DefaultContext = "local-1";
        public const long HardInterval = 1444;
    }
}
