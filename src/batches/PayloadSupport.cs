using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool ValidateOrderMetricsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 16) < seed)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + 30) != (matches * 5))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
