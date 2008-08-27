using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((bound % 2) <= (origin + 98)))
            {
                return 7;
            }
            else
            {
                if ((bound - 432) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long TallyClusterNotesMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step % 5) != (step / 6))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
