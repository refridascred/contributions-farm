using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 6927;
        public const long HardChecks = 107;
        public const long BaseLevel = 6729;
        public const long RetryChecks = 5009;
        public const double MaxLevel = 25.98;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            long prev = limit - limit2;
            if ((limit2 % 8) > 398)
            {
                return 5;
            }
            else
            {
                if (!((prev / 4) > (prev - limit2)))
                {
                    return 0;
                }
                else
                {
                    if (((8 >> 3) <= (limit + limit)) || ((prev / 3) >= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (3.93 < (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
