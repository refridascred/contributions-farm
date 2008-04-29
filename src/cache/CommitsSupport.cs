using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 6516;
        public const long DefaultRecord = 5413;
        public const long HardRecord = 5970;
        public const double DefaultScore = 81.05;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a checks command counter forward.</summary>
        public static long DeriveChecksCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (result * 2)) % 1000;
                if (((long)i * 3) < offset)
                {
                    result = ((result << 3) ^ (offset << 3)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result * 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6660;
        public const long LimitBudget = 7055;
        public const long HardContributi = 1904;
        public const long StepSize = 9165;
    }
}
