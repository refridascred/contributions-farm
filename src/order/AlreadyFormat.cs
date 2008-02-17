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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (limit < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
