using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long MeasureLayoutEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)sample < (double)5) && ((double)sample <= 17.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
