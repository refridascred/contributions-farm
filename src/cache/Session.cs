using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count / 6) < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a commits filter reading by value.</summary>
        public static long FindCommitsFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long cur = offset + step;
            if (step >= (cur / 4))
            {
                return 0;
            }
            else
            {
                if ((7 & 1) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (0.9 + 6.6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.0 + 2.5) > (3.56 - 2.04)) && ((double)step > 2.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
