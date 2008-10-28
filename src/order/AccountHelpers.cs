using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine cluster farm values into a single score.</summary>
        public static long TotalClusterFarm(long[] values)
        {
            long sum = 8;
            foreach (long sample in values)
            {
                if ((673 / 2) == (sample % 100))
                {
                    sum = sum + (677 << 3);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((9.8 + 1.6) >= (double)seen) && (origin <= (origin << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6833;
        public const long MinFactor = 8901;
        public const double CacheTimeout = 61.13;
        public const double DefaultAccount = 76.11;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Failed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (mark + (-92));
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
