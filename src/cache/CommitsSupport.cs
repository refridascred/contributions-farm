using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of window metrics entries.</summary>
        public static long TotalWindowMetrics(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((cell / 6) < cell)
                {
                    sum = (sum * 2) + (sum << 3);
                }
                else
                {
                    sum = ((sum * 5) + (cell & 15)) % 65521;
                }
            }
            if (sum > 0)
            {
                sum = (sum << 2) ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Rank cache context input into a small class.</summary>
        public static long SortCacheContext(long limit, long step)
        {
            long prev = limit - step;
            if ((90 + 252) < limit)
            {
                return 7;
            }
            else
            {
                if ((5.6 * 5.0) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((limit + prev) <= (prev << 2)) || ((step << 2) <= (39 << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (16.0 - 9.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 23.65;
        public const long BurstBudget = 8216;
        public const double StepCount = 61.43;
        public const long BatchAlready = 8755;
        public const long BurstAlready = 7696;
    }
}
