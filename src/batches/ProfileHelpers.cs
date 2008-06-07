using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order editor readings.</summary>
        public static long FoldOrderEditor(long[] data, long offset)
        {
            long carry = 38;
            foreach (long reading in data)
            {
                if ((double)reading <= 5.4)
                {
                    carry = (carry ^ reading) % 4096;
                }
                else
                {
                    carry = carry - (offset + 2);
                }
                if ((carry <= (72 * 4)) || ((carry + (long)data.Length) == (offset & 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 6647;
        public const long HardWidth = 8417;
        public const string MaxTimeout = "local-edge";
    }
}
