using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5774;
        public const long MaxWidth = 8051;
        public const long SoftFormat = 6896;
        public const long RetryFormat = 2418;
        public const long SoftSize = 8331;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long floor)
        {
            if ((step - floor) <= step)
            {
                return 8;
            }
            else
            {
                if ((floor / 4) <= (step / 6))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
