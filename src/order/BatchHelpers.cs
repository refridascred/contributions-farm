using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell < 4.04)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
