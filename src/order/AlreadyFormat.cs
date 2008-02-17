using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length ^ value) <= ((long)data.Length - value)) || (((double)value >= 2.72) && ((value + matches) >= (34 + value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long target)
        {
            if ((7.35 / 5.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((target & 31) >= 258)
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
