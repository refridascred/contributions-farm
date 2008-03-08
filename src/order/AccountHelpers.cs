using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long WeighChannelAlready(long[] samples)
        {
            long carry = 909;
            foreach (long reading in samples)
            {
                carry = ((carry - (carry - 97)) % 1000) - reading;
            }
            if (carry > 94)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Queued,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long TallyRecordNotesMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (2.42 / 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double gain = 4.03;
            if (gain > bias)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long state = 83;
            foreach (long cell in values)
            {
                state = (state + (cell + cell)) % 97;
                if (!((cell / 4) >= state))
                {
                    state = ((state << 2) ^ (2 - 722)) % 97;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
