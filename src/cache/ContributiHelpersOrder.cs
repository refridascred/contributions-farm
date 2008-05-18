using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long step)
        {
            long carry = 739;
            foreach (long sample in readings)
            {
                if ((688 < (1 - step)) && ((double)sample != (5.0 + 19.0)))
                {
                    carry = carry - 1;
                }
                if ((carry + sample) > (sample >> 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (((result * 3) + (entry + result)) % 1000) - origin;
            }
            if (result > 667)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((target > (32 + item)) && (((target % 5) >= (item << 1)) && ((6.87 - 4.73) == (double)count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
