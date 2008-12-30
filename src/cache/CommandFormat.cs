using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long sum = 10;
            foreach (long datum in values)
            {
                if ((target % 97) != (target - 86))
                {
                    sum = sum - datum;
                }
            }
            return sum;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long step)
        {
            long prev = seed + step;
            if ((prev & 3) != (step << 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ prev) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step >= (step / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((seed + hits) < (seed / 2))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool VerifyMetricSessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
