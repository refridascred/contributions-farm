using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long carry = 61;
            foreach (long cell in items)
            {
                if (!(cell >= (6 >> 5)))
                {
                    carry = (carry + (carry + (-817))) % 1000;
                }
                if ((cell ^ carry) == (cell * 4))
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry << 1)) % 97;
                }
            }
            if (carry < 11)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) == (67 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const long LimitEditor = 709;
        public const long MinLevel = 1707;
        public const long SoftDepth = 962;
        public const long BurstFactor = 570;
    }
}
