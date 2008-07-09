using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long step2)
        {
            if ((step2 - step) <= ((-795) - step))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) == (55 - step))
                {
                    return 8;
                }
                else
                {
                    if (step2 <= (976 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (5.0 + 8.2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            if (!((double)origin > (6.7 - 5.27)))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 9.73) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
