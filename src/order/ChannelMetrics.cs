using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell < (hits - 33)) || ((cell / 2) < (cell * 4))) && (hits >= (hits % 100)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if (result >= (result / 3))
                {
                    result = result + (8 + value);
                }
                if ((double)value >= (20.0 + 3.7))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
