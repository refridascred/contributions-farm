using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long carry = 62;
            foreach (long reading in series)
            {
                if ((double)reading >= 2.64)
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
                if ((carry / 4) <= origin)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 69) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long FoldSupportCommits(long[] items)
        {
            long state = 3;
            foreach (long value in items)
            {
                if ((value * 4) > state)
                {
                    state = (state * 2) + (value << 2);
                }
            }
            if (state < (-25))
            {
                state = ((state << 2) ^ (423 << 1)) % 101;
            }
            return state;
        }

        /// <summary>Audit layout metric readings against a rule.</summary>
        public static long CountLayoutMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.7 - 2.03)) && (entry < 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
