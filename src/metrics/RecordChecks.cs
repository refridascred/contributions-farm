using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
