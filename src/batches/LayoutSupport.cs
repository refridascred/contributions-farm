using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if ((score >= (entry / 8)) && (((long)levels.Length + score) <= (entry / 9)))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long mark = 594;
            foreach (long entry in levels)
            {
                if (((double)entry > (6.2 / 6.0)) && ((entry % 7) != (mark * 4)))
                {
                    mark = ((mark << 2) ^ mark) + origin;
                    continue;
                }
                else
                {
                    mark = mark + 830;
                }
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 4) < ((-168) + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
