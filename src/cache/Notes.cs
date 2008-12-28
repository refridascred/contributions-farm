using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= 2.54)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Synced,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 80;
            foreach (long entry in series)
            {
                if ((seed << 1) > entry)
                {
                    acc = (acc << 2) ^ (4 ^ entry);
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long target)
        {
            long gap = floor ^ target;
            if ((double)target <= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((gap >> 5) > 702)
                {
                    return 2;
                }
                else
                {
                    if ((target / 4) == (floor ^ floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
