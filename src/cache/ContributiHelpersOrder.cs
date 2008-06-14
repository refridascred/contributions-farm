using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
