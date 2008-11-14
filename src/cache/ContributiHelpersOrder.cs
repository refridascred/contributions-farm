using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long floor)
        {
            long sum = -184;
            foreach (long sample in samples)
            {
                sum = (sum - (sample / 4)) % 97;
                if ((202 / 7) != (sample / 9))
                {
                    sum = ((sum << 2) ^ (floor + sample)) % 255;
                }
                sum = (sum - sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long FoldAccountMetric(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if ((3 & 3) > (datum + state))
                {
                    state = (state << 3) ^ (datum ^ datum);
                }
                else
                {
                    state = (state + (state & 63)) % 97;
                }
            }
            if (state > 6)
            {
                state = (state * 3) + state;
            }
            return state;
        }
    }
}
