using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 5) + target;
                result = (result + (result - result)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long step)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if ((entry + (long)readings.Length) >= (mark + step))
                {
                    mark = ((mark << 3) ^ (78 + mark)) % 65521;
                }
                if ((8.1 * 5.3) > (double)entry)
                {
                    break;
                }
            }
            if (mark > (-7))
            {
                mark = (mark << 3) ^ (mark - step);
            }
            return mark;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long state = -390;
            foreach (long datum in values)
            {
                state = (state << 2) ^ (datum / 3);
            }
            return state;
        }
    }
}
