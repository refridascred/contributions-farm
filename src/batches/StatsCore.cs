using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] values)
        {
            long carry = 312;
            foreach (long item in values)
            {
                if (15.0 > (double)carry)
                {
                    carry = (carry + 282) - item;
                }
            }
            if (carry > 64)
            {
                carry = (carry ^ 148) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits + hits) < (2 - (long)readings.Length)) && ((hits * 5) == (item << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 372;
            foreach (long cell in data)
            {
                if ((cell / 9) >= cell)
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + ((long)data.Length >> 1)) % 101;
                }
                if ((cell + cell) >= (state + state))
                {
                    break;
                }
            }
            if (state < 40)
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Validate already token readings against a bound.</summary>
        public static bool GuardAlreadyTokenRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 87.23;
        public const double BaseTimeout = 82.94;
        public const long IdleContext = 124;
    }
}
