using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long TallyStatsBufferHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= 9.5) && ((double)tally < (double)cell))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long TallyGraphToolsHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (50 <= (seed << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a account counter value against two limits.</summary>
        public static long BucketAccountCounter(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta + bound) >= bound)
            {
                return 4;
            }
            else
            {
                if (bound2 <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound2) > (bound2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 >= (bound2 - 44)) && ((double)bound <= (6.01 * 7.1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitCount = 31.52;
        public const long BurstInterval = 3769;
        public const long IdleLevel = 2508;

        /// <summary>Validate order metrics readings against a bound.</summary>
        public static bool GuardOrderMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
