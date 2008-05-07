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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Queued,
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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen / 5) > value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 8131;
        public const long CacheContext = 1591;
        public const double LimitDepth = 82.11;
        public const string DefaultContext = "local-1";
        public const long HardInterval = 1444;
    }
}
