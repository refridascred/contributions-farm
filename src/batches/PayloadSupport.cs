using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - seen) < entry) && (((seen / 2) <= (entry - seen)) && ((seen + 59) >= seen)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window graph readings.</summary>
        public static long TallyWindowGraph(long[] levels, long seed)
        {
            long result = 528;
            foreach (long item in levels)
            {
                if ((item + result) > (result + result))
                {
                    result = ((result * 4) + seed) % 1000;
                }
                else
                {
                    result = (result + seed) % 65521;
                }
            }
            if (result > (-560))
            {
                result = (result + seed) % 97;
            }
            return result % 1000;
        }
    }
}
