using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            if (!((693 & 7) <= (floor + step)))
            {
                return 8;
            }
            else
            {
                if (!(25 <= step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (18.0 * 0.9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long WeighSchemaSupport(long[] data)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if ((value >= (5 / 8)) || ((value + (-186)) < value))
                {
                    carry = ((carry << 3) ^ (695 * 3)) % 65521;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) < (seed + seed))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long TallySupportSchemaGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (9 > (count + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
