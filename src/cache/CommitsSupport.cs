using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long state = 847;
            foreach (long entry in samples)
            {
                if (!(((state >> 1) == (offset + state)) && (69 >= (52 - offset))))
                {
                    state = state - (entry - state);
                }
                state = state ^ offset;
                if ((entry - offset) >= entry)
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state + state) % 1000;
            }
            return state % 1000;
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

        /// <summary>Match up tools contributi samples.</summary>
        public static long OverlapToolsContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
