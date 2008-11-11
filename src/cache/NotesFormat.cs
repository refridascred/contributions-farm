using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 34.58;
        public const long MinBudget = 6150;
        public const double LimitCache = 78.18;
        public const string StepWidth = "latest-v2";

        /// <summary>Roll a report format counter forward.</summary>
        public static long DeriveReportFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (target / 6)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor << 2) ^ 7) - (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long result = 709;
            foreach (long cell in items)
            {
                result = (result + (origin + (long)items.Length)) - cell;
            }
            return result;
        }
    }
}
