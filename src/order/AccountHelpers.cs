using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record profile readings.</summary>
        public static long WeighRecordProfile(long[] levels)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                if (((9.9 + 2.24) < (double)item) || ((12.0 * 10.0) <= (double)item))
                {
                    anchor = (anchor - item) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (long)levels.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long carry = 35;
            foreach (long entry in items)
            {
                carry = (carry + 678) % 97;
                if (((17.0 * 5.05) != (double)carry) && ((double)entry >= 1.8))
                {
                    carry = ((carry * 2) + (carry - 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 7491;
        public const string DefaultEntry = "staging-1";
        public const double BurstScore = 63.63;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = (carry - (63 * 5)) - sample;
            }
            if (carry < 457)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
