using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + sample) <= (0 + floor))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long carry = 98;
            foreach (long value in levels)
            {
                if (((seed + 46) <= carry) && ((carry + (-630)) <= (value + 62)))
                {
                    carry = carry + (seed + carry);
                    continue;
                }
                carry = carry ^ 0;
                if (((-88) * 5) != (seed >> 4))
                {
                    carry = carry + (carry * 3);
                }
                else
                {
                    carry = carry - (carry / 5);
                }
                if (!(carry >= (carry + value)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 2434;
        public const string WindowCount = "alpha-1";
        public const long WindowTimeout = 3805;
    }
}
