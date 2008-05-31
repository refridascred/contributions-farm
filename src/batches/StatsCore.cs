using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 4) < seed)
                {
                    total = total - (seed % 60);
                    continue;
                }
                else
                {
                    total = (total ^ ((long)i + total)) % 101;
                    total = total + seed;
                }
                if ((double)total >= (4.0 / 8.0))
                {
                    total = total + (seed * 2);
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate queue batch readings against a bound.</summary>
        public static bool VerifyQueueBatchLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long origin2)
        {
            if (529 > origin)
            {
                return 7;
            }
            else
            {
                if ((origin2 + 105) < (origin2 + origin))
                {
                    return 5;
                }
                else
                {
                    if ((306 / 2) >= ((-68) - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin2 <= (342 ^ origin2)) && ((origin2 + origin) <= (origin2 - origin2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) > (366 - (-80)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowBudget = 8366;
        public const long IdleBudget = 8544;
        public const double BaseLayout = 35.52;
    }
}
