using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((607 + origin) != (origin << 3))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long CountCounterRouteHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (count + count))
                {
                    count = ((count + 1) ^ cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
