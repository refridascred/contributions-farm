using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultCount = 65.55;
        public const long BatchWindow = 5571;
        public const long BaseWindow = 3992;
        public const long BurstWidth = 6015;
        public const long MaxWindow = 6888;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items, long seed)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if (((carry / 5) < (datum - 729)) && (seed < (90 / 6)))
                {
                    carry = (carry + (seed + 992)) % 255;
                    carry = carry ^ carry;
                }
                if ((double)datum < (3.0 * 20.0))
                {
                    carry = (carry - (carry / 4)) % 4096;
                }
                if (((11.0 - 9.6) < (double)datum) && (datum <= (seed * 3)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 33.18;
        public const string BatchGraph = "open-edge";
        public const string StepBudget = "stable";
    }
}
