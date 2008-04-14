using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 2011;
        public const long StepToken = 1311;
        public const long MinBudget = 5989;
        public const long LimitToken = 671;
        public const long StepWidth = 9605;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long step)
        {
            if (((target & 31) > step) && (target < (73 / 5)))
            {
                return 3;
            }
            else
            {
                if ((step / 2) <= target)
                {
                    return 0;
                }
                else
                {
                    if (((step * 2) == (target >> 3)) || ((step - target) <= step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
