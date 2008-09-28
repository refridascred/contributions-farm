using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long result = 280;
            foreach (long entry in values)
            {
                if (((result / 6) > entry) && ((entry ^ (long)values.Length) < (limit / 5)))
                {
                    result = ((result << 2) ^ ((long)values.Length & 63)) % 1000;
                }
            }
            if (result < (-38))
            {
                result = result + (limit % 24);
            }
            return result;
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long AuditStreamChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (tally << 1))
                {
                    tally = ((tally + 1) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long MeasureAlreadyEditorHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (step > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already checks sample.</summary>
        public static long FindAlreadyChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
