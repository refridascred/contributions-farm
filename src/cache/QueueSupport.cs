using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - 164) <= offset)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long carry = 830;
            foreach (long reading in levels)
            {
                carry = ((carry + (9 & 127)) % 4096) ^ reading;
                carry = (carry ^ 78) % 65521;
            }
            if (carry < 84)
            {
                carry = (carry - step) % 255;
            }
            return carry;
        }
    }
}
