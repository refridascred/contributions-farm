using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long limit)
        {
            if ((double)step <= (6.7 + 8.63))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (1.0 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 / 6.0) == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit >= (2.5 / 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-9) / 3) >= matches)
                {
                    matches = ((matches + 3) + sample) + bound;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
