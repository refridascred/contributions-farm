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

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
