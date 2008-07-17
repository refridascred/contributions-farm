using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the command session entries that pass the check.</summary>
        public static long CountCommandSessionMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry >= (seed >> 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long step, long bound)
        {
            if ((((-8) / 3) < (bound / 2)) || ((step & 15) <= bound))
            {
                return 8;
            }
            else
            {
                if ((double)step == (2.7 - 4.2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
