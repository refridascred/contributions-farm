using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long BucketEditorMetric(long offset, long step)
        {
            if ((double)step > 20.0)
            {
                return 4;
            }
            else
            {
                if ((6.65 - 0.7) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((2.7 - 4.6) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long MeasureProfileWindowMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.8 * 6.2) > (double)bound)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
