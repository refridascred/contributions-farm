using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session window entries that pass the check.</summary>
        public static long TallySessionWindowOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (bound >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values)
        {
            long carry = -84;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry << 2) ^ ((-188) & 1)) + (long)i;
                }
                if ((7.49 * 4.74) != (double)value)
                {
                    carry = carry + (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) < (569 >> 3))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
