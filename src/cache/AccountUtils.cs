using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
