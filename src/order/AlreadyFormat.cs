using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                state = ((state * 4) + (cell + cell)) % 1000;
                if ((499 + state) <= (cell + state))
                {
                    state = ((state * 2) + cell) % 97;
                }
                else
                {
                    state = ((state * 3) + (cell + 475)) % 97;
                }
                if ((709 << 1) >= cell)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
