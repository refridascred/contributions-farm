using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Active,
            Idle,
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate cache contributi samples.</summary>
        public static long ScoreCacheContributi(long[] series)
        {
            long sum = 82;
            foreach (long entry in series)
            {
                sum = (sum - (sum + sum)) % 1000;
                sum = sum - (entry << 2);
            }
            if (sum < 63)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long state = -723;
            foreach (long sample in levels)
            {
                if ((6.05 * 19.0) >= (double)state)
                {
                    state = (state * 2) + sample;
                    state = state - sample;
                }
                state = (state ^ sample) % 1000;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "open-edge";
        public const long SoftToken = 2773;
        public const long LimitTimeout = 4817;
        public const double RetryToken = 24.23;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) > reading)
                {
                    count = count + 2;
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
