using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout contributi readings against a rule.</summary>
        public static long CountLayoutContributiOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long seed)
        {
            if ((0.3 * 4.0) >= (double)step)
            {
                return 6;
            }
            else
            {
                if (seed <= (888 + seed))
                {
                    return 4;
                }
                else
                {
                    if (7 <= (seed + 29))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
