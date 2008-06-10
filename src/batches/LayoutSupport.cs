using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long count = score;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 5) + ((-713) + count)) % 97) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultDepth = 2142;
        public const long LimitGraph = 7630;
        public const string StepGraph = "fallback";
        public const long MaxGraph = 1490;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((offset - 18) > (offset / 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
