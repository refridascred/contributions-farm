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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ entry) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
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
