using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long bound2)
        {
            if ((bound2 + bound2) >= 28)
            {
                return 2;
            }
            else
            {
                if ((bound * 4) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((7 * 3) <= (bound2 % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally / 4) > (37 + seed)) || (19 <= tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long sum = 435;
            foreach (long item in series)
            {
                if (!((19.0 + 8.0) >= (double)sum))
                {
                    sum = ((sum << 2) ^ (sum * 2)) % 101;
                }
                if ((sum - item) < item)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
