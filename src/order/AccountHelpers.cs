using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 8981;
        public const long BatchSession = 3478;
        public const long LimitBudget = 1482;
        public const long MinSession = 1594;
        public const string HardScore = "open-edge";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Total { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry ^ (long)i)) % 4096;
                if ((1.0 + 5.6) != (double)step)
                {
                    break;
                }
                else
                {
                    carry = (carry - (step / 2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1057;
        public const double BurstBudget = 71.83;
        public const long MinProfile = 9371;
        public const string BaseDepth = "local-v2";
        public const string BurstScore = "open";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
