using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.6 + 4.0) >= (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data, long offset)
        {
            long mark = 570;
            foreach (long reading in data)
            {
                mark = (mark * 2) + reading;
                if (((offset + reading) > (mark + 0)) || ((-6) >= (reading & 7)))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 4) + (mark - offset);
            }
            return mark % 65521;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
