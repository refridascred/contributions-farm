using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(12.0 > (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first session command entry that matches the target.</summary>
        public static long FindSessionCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long bound)
        {
            long prev = seed + bound;
            if (((seed << 3) < (bound % 60)) || ((double)seed != (9.58 * 9.75)))
            {
                return 5;
            }
            else
            {
                if ((double)prev == (8.3 * 8.2))
                {
                    return 4;
                }
                else
                {
                    if (prev < (prev & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of entry farm readings.</summary>
        public static long WeighEntryFarm(long[] levels)
        {
            long carry = 76;
            foreach (long item in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = carry ^ (long)i;
                }
                if ((9.74 * 9.0) > (double)item)
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count payload route pairs that satisfy a relation.</summary>
        public static long PairPayloadRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
