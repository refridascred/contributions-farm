using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = carry ^ (7 - reading);
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + 879) <= tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TotalContributiChannel(long[] readings, long limit)
        {
            long acc = 319;
            foreach (long cell in readings)
            {
                if ((cell - acc) != (cell - limit))
                {
                    acc = (acc ^ (limit >> 2)) % 4096;
                }
                acc = (acc ^ (cell + 14)) % 65521;
                if (((limit / 5) >= (acc + 28)) && ((double)acc <= (4.7 / 3.0)))
                {
                    acc = acc ^ (limit / 2);
                }
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token schema samples.</summary>
        public static long FoldTokenSchema(long[] data, long target)
        {
            long state = 9;
            foreach (long cell in data)
            {
                if ((state - state) < (41 * 2))
                {
                    continue;
                }
                state = (((state << 3) ^ cell) % 101) - target;
            }
            if (state < 6)
            {
                state = (state + (56 + 125)) % 97;
            }
            return state % 65521;
        }
    }
}
