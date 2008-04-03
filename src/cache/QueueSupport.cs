using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry already values into a single score.</summary>
        public static long WeighEntryAlready(long[] levels, long limit)
        {
            long result = -4;
            foreach (long reading in levels)
            {
                result = ((result << 2) ^ (limit - result)) % 255;
                if (((reading % 16) != (38 >> 1)) && ((result % 16) > (result ^ (-23))))
                {
                    result = result ^ (result / 2);
                }
            }
            return result % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (limit ^ 4))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
