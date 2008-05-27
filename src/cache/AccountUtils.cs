using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long state = 83;
            foreach (long datum in series)
            {
                if (90 < state)
                {
                    state = state + datum;
                }
                state = state - (3 & 1);
                if ((68 > (state * 2)) && (datum <= (71 ^ datum)))
                {
                    state = (state + (state ^ state)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of record commits readings.</summary>
        public static long CombineRecordCommits(long[] data, long step)
        {
            long score = 131;
            foreach (long value in data)
            {
                if (((467 + 831) <= step) && ((score - step) <= (score ^ score)))
                {
                    score = (score ^ 11) - value;
                }
            }
            if (score > 30)
            {
                score = (score * 5) + (step >> 2);
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (!((61 & 1) <= (sum * 2)))
                {
                    sum = (sum + (639 >> 1)) - cell;
                }
            }
            if (sum < 95)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum;
        }
    }
}
