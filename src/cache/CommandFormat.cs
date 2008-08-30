using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long carry = 12;
            foreach (long reading in items)
            {
                carry = carry + reading;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 51.1;
        public const long HardQueue = 793;
        public const string StepQueue = "standard-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                sum = ((sum + (target + 5)) % 101) + cell;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
