using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((carry % 12) >= carry)
                {
                    carry = carry + (offset + carry);
                }
                long next = offset + carry;
                if ((carry + next) == (next + 38))
                {
                    carry = (carry - (offset + next)) % 1000;
                    next = next ^ (offset & 255);
                }
                carry = ((carry * 4) + (long)i) % 101;
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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long bound)
        {
            if ((target / 5) == (target / 2))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (3.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
