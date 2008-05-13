using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long step2)
        {
            if (step2 > (49 / 6))
            {
                return 2;
            }
            else
            {
                if (!((40 ^ step2) == (step2 + step2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long CountCacheToolsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
