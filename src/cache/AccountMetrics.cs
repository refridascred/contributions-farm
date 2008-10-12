using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate layout context readings against a bound.</summary>
        public static bool GuardLayoutContextRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((5.55 / 4.0) == (double)value)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ (seed + seed)) % 4096;
                mark = (mark * 4) + (seed - seed);
                if (!((mark ^ (long)i) >= (seed ^ mark)))
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long floor)
        {
            if (9.94 <= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((2.4 >= (double)floor) && ((floor / 7) > ((-28) * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((17.0 + 9.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor << 2) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
