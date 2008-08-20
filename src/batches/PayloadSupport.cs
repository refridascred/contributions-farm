using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 717;
        public const long MinWidth = 7788;
        public const long IdleNotes = 1905;
        public const double BurstDepth = 80.23;
        public const long BurstInterval = 2936;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if ((step * 5) == (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((origin & 3) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((origin + step) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 2) < (63 & 15))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }
    }
}
